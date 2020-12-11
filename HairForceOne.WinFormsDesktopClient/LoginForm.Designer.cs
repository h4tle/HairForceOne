namespace HairForceOne.WinFormsDesktopClient
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(510, 244);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(86, 26);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Log ind";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_header.Location = new System.Drawing.Point(263, 73);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(255, 20);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "Indtast Email og Adgangskode";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_email.Location = new System.Drawing.Point(177, 132);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_password.Location = new System.Drawing.Point(177, 180);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(76, 13);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Adgangskode:";
            this.lbl_password.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(266, 132);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(330, 20);
            this.txt_email.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(266, 177);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(330, 20);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(619, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.btn_login);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

