namespace HairForceOne.WinFormsDesktopClient
{
    partial class UserForm
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
            this.lbl_mainheader = new System.Windows.Forms.Label();
            this.btn_backtomain = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_booking_name = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_user_email = new System.Windows.Forms.Label();
            this.lbl_users_mail = new System.Windows.Forms.Label();
            this.lbl_user_phoneno = new System.Windows.Forms.Label();
            this.lbl_userphoneno = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_events_services = new System.Windows.Forms.Label();
            this.lb_users = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_mainheader
            // 
            this.lbl_mainheader.AutoSize = true;
            this.lbl_mainheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mainheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_mainheader.Location = new System.Drawing.Point(530, 65);
            this.lbl_mainheader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mainheader.Name = "lbl_mainheader";
            this.lbl_mainheader.Size = new System.Drawing.Size(500, 82);
            this.lbl_mainheader.TabIndex = 11;
            this.lbl_mainheader.Text = "HairForceOne";
            // 
            // btn_backtomain
            // 
            this.btn_backtomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_backtomain.Location = new System.Drawing.Point(18, 18);
            this.btn_backtomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_backtomain.Name = "btn_backtomain";
            this.btn_backtomain.Size = new System.Drawing.Size(112, 35);
            this.btn_backtomain.TabIndex = 31;
            this.btn_backtomain.Text = "Tilbage";
            this.btn_backtomain.UseVisualStyleBackColor = false;
            this.btn_backtomain.Click += new System.EventHandler(this.btn_backtomain_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_delete.Location = new System.Drawing.Point(706, 906);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 35);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Slet";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_booking_name
            // 
            this.lbl_booking_name.AutoSize = true;
            this.lbl_booking_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_name.Location = new System.Drawing.Point(916, 195);
            this.lbl_booking_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_booking_name.Name = "lbl_booking_name";
            this.lbl_booking_name.Size = new System.Drawing.Size(99, 33);
            this.lbl_booking_name.TabIndex = 36;
            this.lbl_booking_name.Text = "Navn: ";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_user.Location = new System.Drawing.Point(962, 262);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(176, 29);
            this.lbl_user.TabIndex = 35;
            this.lbl_user.Text = "Hjalmer Larsen";
            // 
            // lbl_user_email
            // 
            this.lbl_user_email.AutoSize = true;
            this.lbl_user_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_user_email.Location = new System.Drawing.Point(916, 311);
            this.lbl_user_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user_email.Name = "lbl_user_email";
            this.lbl_user_email.Size = new System.Drawing.Size(97, 33);
            this.lbl_user_email.TabIndex = 38;
            this.lbl_user_email.Text = "Email:";
            // 
            // lbl_users_mail
            // 
            this.lbl_users_mail.AutoSize = true;
            this.lbl_users_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_users_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_users_mail.Location = new System.Drawing.Point(962, 377);
            this.lbl_users_mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_users_mail.Name = "lbl_users_mail";
            this.lbl_users_mail.Size = new System.Drawing.Size(215, 29);
            this.lbl_users_mail.TabIndex = 37;
            this.lbl_users_mail.Text = "hjamler@larsen.dk";
            // 
            // lbl_user_phoneno
            // 
            this.lbl_user_phoneno.AutoSize = true;
            this.lbl_user_phoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_phoneno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_user_phoneno.Location = new System.Drawing.Point(916, 434);
            this.lbl_user_phoneno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user_phoneno.Name = "lbl_user_phoneno";
            this.lbl_user_phoneno.Size = new System.Drawing.Size(228, 33);
            this.lbl_user_phoneno.TabIndex = 39;
            this.lbl_user_phoneno.Text = "Telefonnummer:";
            // 
            // lbl_userphoneno
            // 
            this.lbl_userphoneno.AutoSize = true;
            this.lbl_userphoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userphoneno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_userphoneno.Location = new System.Drawing.Point(962, 494);
            this.lbl_userphoneno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userphoneno.Name = "lbl_userphoneno";
            this.lbl_userphoneno.Size = new System.Drawing.Size(117, 29);
            this.lbl_userphoneno.TabIndex = 40;
            this.lbl_userphoneno.Text = "50414075";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_amount.Location = new System.Drawing.Point(962, 720);
            this.lbl_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(39, 29);
            this.lbl_amount.TabIndex = 42;
            this.lbl_amount.Text = "12";
            // 
            // lbl_events_services
            // 
            this.lbl_events_services.AutoSize = true;
            this.lbl_events_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_events_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_events_services.Location = new System.Drawing.Point(916, 660);
            this.lbl_events_services.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_events_services.Name = "lbl_events_services";
            this.lbl_events_services.Size = new System.Drawing.Size(257, 33);
            this.lbl_events_services.TabIndex = 41;
            this.lbl_events_services.Text = "Antal behandlinger";
            // 
            // lb_users
            // 
            this.lb_users.FormattingEnabled = true;
            this.lb_users.ItemHeight = 20;
            this.lb_users.Location = new System.Drawing.Point(351, 192);
            this.lb_users.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(430, 364);
            this.lb_users.TabIndex = 43;
            this.lb_users.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1512, 1122);
            this.Controls.Add(this.lb_users);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_events_services);
            this.Controls.Add(this.lbl_userphoneno);
            this.Controls.Add(this.lbl_user_phoneno);
            this.Controls.Add(this.lbl_user_email);
            this.Controls.Add(this.lbl_users_mail);
            this.Controls.Add(this.lbl_booking_name);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_backtomain);
            this.Controls.Add(this.lbl_mainheader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mainheader;
        private System.Windows.Forms.Button btn_backtomain;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_booking_name;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_user_email;
        private System.Windows.Forms.Label lbl_users_mail;
        private System.Windows.Forms.Label lbl_user_phoneno;
        private System.Windows.Forms.Label lbl_userphoneno;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_events_services;
        private System.Windows.Forms.ListBox lb_users;
    }
}