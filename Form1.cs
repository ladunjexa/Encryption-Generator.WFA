//==============================================================================
/*
 *            Liron Encryption Application 1.0
 *       (c) Copyright 2012-2013 by Liron
 *
 * @author    : Liron
 * @date      : 26th October 2013
 * @update    : none
 * @team      : none
 *
 * This file is provided as is (no warranties).
 */
//============================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Encrypter
{
    public partial class YL16Encryption : Form
    {
        DataEncryptor keys = new DataEncryptor();
        public YL16Encryption()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Input.Text)) 
                MessageBox.Show("Enter text to encrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else Output.Text = keys.EncryptString(Input.Text);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Input.Text)) 
                MessageBox.Show("Enter code to decrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else Output.Text = keys.DecryptString(Input.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) if (c is TextBox) ((TextBox)c).Clear();
        }
        private void button4_Click(object sender, EventArgs e) { Clipboard.SetText(Output.Text); }
        private void button6_Click(object sender, EventArgs e) { Input.Text = Clipboard.GetText(); }
        private void label3_Click(object sender, EventArgs e) { }

        private Random _random = new Random(Environment.TickCount);

        public string RandomString(int length)
        {
            string chars = @"0123456789abcdefghijklmnopqrstuvwxyz!@#$%^|&*()_+=-,.:';/\";
            StringBuilder builder = new StringBuilder(length);

            for (int i = 0; i < length; ++i)
                builder.Append(chars[_random.Next(chars.Length)]);

            return builder.ToString();
        }

    }

    public class DataEncryptor
    {
        TripleDESCryptoServiceProvider symm;

        #region Factory
        public DataEncryptor()
        {
            this.symm = new TripleDESCryptoServiceProvider();
            this.symm.Padding = PaddingMode.PKCS7;
        }
        public DataEncryptor(TripleDESCryptoServiceProvider keys)
        { this.symm = keys; }

        public DataEncryptor(byte[] key, byte[] iv)
        {
            this.symm = new TripleDESCryptoServiceProvider();
            this.symm.Padding = PaddingMode.PKCS7;
            this.symm.Key = key;
            this.symm.IV = iv;
        }

        #endregion

        #region Properties
        public TripleDESCryptoServiceProvider Algorithm
            { get { return symm; } set { symm = value; } }
        public byte[] Key
            { get { return symm.Key; } set { symm.Key = value; } }
        public byte[] IV
            { get { return symm.IV; } set { symm.IV = value; } }

        #endregion

        #region Crypto

        public byte[] Encrypt(byte[] data) { return Encrypt(data, data.Length); }
        public byte[] Encrypt(byte[] data, int length)
        {
            try
            {
                // Create a MemoryStream.
                var ms = new MemoryStream();

                // Create a CryptoStream using the MemoryStream 
                // and the passed key and initialization vector (IV).
                var cs = new CryptoStream(ms,
                    symm.CreateEncryptor(symm.Key, symm.IV),
                    CryptoStreamMode.Write);

                // Write the byte array to the crypto stream and flush it.
                cs.Write(data, 0, length);
                cs.FlushFinalBlock();

                // Get an array of bytes from the 
                // MemoryStream that holds the 
                // encrypted data.
                byte[] ret = ms.ToArray();

                // Close the streams.
                cs.Close();
                ms.Close();

                // Return the encrypted buffer.
                return ret;
            }
            catch (CryptographicException ex)
                { Console.WriteLine("A cryptographic error occured: {0}", ex.Message); }
            return null;
        }

        public string EncryptString(string text)
            { return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(text))); }

        public byte[] Decrypt(byte[] data) { return Decrypt(data, data.Length); }
        public byte[] Decrypt(byte[] data, int length)
        {
            try
            {
                // Create a new MemoryStream using the passed 
                // array of encrypted data.
                MemoryStream ms = new MemoryStream(data);

                // Create a CryptoStream using the MemoryStream 
                // and the passed key and initialization vector (IV).
                CryptoStream cs = new CryptoStream(ms,
                    symm.CreateDecryptor(symm.Key, symm.IV),
                    CryptoStreamMode.Read);

                // Create buffer to hold the decrypted data.
                byte[] result = new byte[length];

                // Read the decrypted data out of the crypto stream
                // and place it into the temporary buffer.
                cs.Read(result, 0, result.Length);
                return result;
            }
            catch (CryptographicException ex)
                { Console.WriteLine("A cryptographic error occured: {0}", ex.Message); }
            return null;
        }

        public string DecryptString(string data)
            { return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(data))).TrimEnd('\0'); }

        #endregion

    }
}
