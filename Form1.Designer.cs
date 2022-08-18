namespace Encrypter
{
    partial class YL16Encryption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.softwareTitle = new System.Windows.Forms.Label();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.Credits = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Paste = new System.Windows.Forms.Button();
            this.Divider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 46);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(241, 20);
            this.Input.TabIndex = 0;
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(259, 44);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(103, 23);
            this.Encrypt.TabIndex = 2;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // softwareTitle
            // 
            this.softwareTitle.AutoSize = true;
            this.softwareTitle.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.softwareTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.softwareTitle.Location = new System.Drawing.Point(123, 8);
            this.softwareTitle.Name = "softwareTitle";
            this.softwareTitle.Size = new System.Drawing.Size(209, 29);
            this.softwareTitle.TabIndex = 4;
            this.softwareTitle.Text = "YL16 Encryption";
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(364, 44);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(103, 23);
            this.Decrypt.TabIndex = 6;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 118);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(448, 90);
            this.Output.TabIndex = 7;
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Credits.ForeColor = System.Drawing.Color.DarkBlue;
            this.Credits.Location = new System.Drawing.Point(17, 75);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(161, 26);
            this.Credits.TabIndex = 8;
            this.Credits.Text = "(c) Developed by [T]he3DeVi[L] \r\n(younglirz16@gmail.com)";
            this.Credits.Click += new System.EventHandler(this.label2_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Clear.ForeColor = System.Drawing.Color.Gray;
            this.Clear.Location = new System.Drawing.Point(233, 214);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(103, 23);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // Copy
            // 
            this.Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Copy.ForeColor = System.Drawing.Color.Gray;
            this.Copy.Location = new System.Drawing.Point(125, 214);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(103, 23);
            this.Copy.TabIndex = 10;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.button4_Click);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(259, 70);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(103, 23);
            this.Paste.TabIndex = 12;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.button6_Click);
            // 
            // Divider
            // 
            this.Divider.AutoSize = true;
            this.Divider.Location = new System.Drawing.Point(15, 101);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(439, 13);
            this.Divider.TabIndex = 13;
            this.Divider.Text = "________________________________________________________________________\r\n";
            // 
            // YL16Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 245);
            this.Controls.Add(this.Divider);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.softwareTitle);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.Input);
            this.Name = "YL16Encryption";
            this.Text = "YL16 Encryption (Developed by T3D)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Label softwareTitle;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Label Divider;
    }
}

