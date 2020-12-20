namespace HairForceOne.WinFormsDesktopClient
{
    partial class NewEmployeeForm
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
            this.num_employee_exp = new System.Windows.Forms.NumericUpDown();
            this.lbl_employee_exp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_employee_phoneno = new System.Windows.Forms.TextBox();
            this.lbl_employee_email = new System.Windows.Forms.Label();
            this.txt_employee_email = new System.Windows.Forms.TextBox();
            this.lbl_employee_lastname = new System.Windows.Forms.Label();
            this.txt_employee_lastname = new System.Windows.Forms.TextBox();
            this.lbl_employee_firstname = new System.Windows.Forms.Label();
            this.txt_employee_firstname = new System.Windows.Forms.TextBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.lbl_employee_biography = new System.Windows.Forms.Label();
            this.txt_employee_biography = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_employee_roles = new System.Windows.Forms.ComboBox();
            this.lbl_employee_roles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_employee_password = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_employee_exp)).BeginInit();
            this.SuspendLayout();
            // 
            // num_employee_exp
            // 
            this.num_employee_exp.Location = new System.Drawing.Point(123, 177);
            this.num_employee_exp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_employee_exp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_employee_exp.Name = "num_employee_exp";
            this.num_employee_exp.Size = new System.Drawing.Size(80, 20);
            this.num_employee_exp.TabIndex = 78;
            this.num_employee_exp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_employee_exp
            // 
            this.lbl_employee_exp.AutoSize = true;
            this.lbl_employee_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_exp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_exp.Location = new System.Drawing.Point(120, 162);
            this.lbl_employee_exp.Name = "lbl_employee_exp";
            this.lbl_employee_exp.Size = new System.Drawing.Size(55, 13);
            this.lbl_employee_exp.TabIndex = 77;
            this.lbl_employee_exp.Text = "Erfaring:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(120, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Telefonnummer:";
            // 
            // txt_employee_phoneno
            // 
            this.txt_employee_phoneno.Location = new System.Drawing.Point(123, 139);
            this.txt_employee_phoneno.Name = "txt_employee_phoneno";
            this.txt_employee_phoneno.Size = new System.Drawing.Size(284, 20);
            this.txt_employee_phoneno.TabIndex = 75;
            this.txt_employee_phoneno.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_employee_email
            // 
            this.lbl_employee_email.AutoSize = true;
            this.lbl_employee_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_email.Location = new System.Drawing.Point(120, 84);
            this.lbl_employee_email.Name = "lbl_employee_email";
            this.lbl_employee_email.Size = new System.Drawing.Size(37, 13);
            this.lbl_employee_email.TabIndex = 74;
            this.lbl_employee_email.Text = "Email";
            // 
            // txt_employee_email
            // 
            this.txt_employee_email.Location = new System.Drawing.Point(123, 100);
            this.txt_employee_email.Name = "txt_employee_email";
            this.txt_employee_email.Size = new System.Drawing.Size(284, 20);
            this.txt_employee_email.TabIndex = 73;
            this.txt_employee_email.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_employee_lastname
            // 
            this.lbl_employee_lastname.AutoSize = true;
            this.lbl_employee_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_lastname.Location = new System.Drawing.Point(120, 45);
            this.lbl_employee_lastname.Name = "lbl_employee_lastname";
            this.lbl_employee_lastname.Size = new System.Drawing.Size(66, 13);
            this.lbl_employee_lastname.TabIndex = 72;
            this.lbl_employee_lastname.Text = "Efternavn:";
            // 
            // txt_employee_lastname
            // 
            this.txt_employee_lastname.Location = new System.Drawing.Point(123, 61);
            this.txt_employee_lastname.Name = "txt_employee_lastname";
            this.txt_employee_lastname.Size = new System.Drawing.Size(284, 20);
            this.txt_employee_lastname.TabIndex = 71;
            this.txt_employee_lastname.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_employee_firstname
            // 
            this.lbl_employee_firstname.AutoSize = true;
            this.lbl_employee_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_firstname.Location = new System.Drawing.Point(120, 6);
            this.lbl_employee_firstname.Name = "lbl_employee_firstname";
            this.lbl_employee_firstname.Size = new System.Drawing.Size(57, 13);
            this.lbl_employee_firstname.TabIndex = 70;
            this.lbl_employee_firstname.Text = "Fornavn:";
            // 
            // txt_employee_firstname
            // 
            this.txt_employee_firstname.Location = new System.Drawing.Point(123, 22);
            this.txt_employee_firstname.Name = "txt_employee_firstname";
            this.txt_employee_firstname.Size = new System.Drawing.Size(284, 20);
            this.txt_employee_firstname.TabIndex = 69;
            this.txt_employee_firstname.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Checked = true;
            this.rb_female.Location = new System.Drawing.Point(214, 217);
            this.rb_female.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(58, 17);
            this.rb_female.TabIndex = 86;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Kvinde";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(123, 217);
            this.rb_male.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(52, 17);
            this.rb_male.TabIndex = 85;
            this.rb_male.Text = "Mand";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // lbl_employee_biography
            // 
            this.lbl_employee_biography.AutoSize = true;
            this.lbl_employee_biography.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_biography.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_biography.Location = new System.Drawing.Point(121, 247);
            this.lbl_employee_biography.Name = "lbl_employee_biography";
            this.lbl_employee_biography.Size = new System.Drawing.Size(58, 13);
            this.lbl_employee_biography.TabIndex = 83;
            this.lbl_employee_biography.Text = "Biografi: ";
            // 
            // txt_employee_biography
            // 
            this.txt_employee_biography.Location = new System.Drawing.Point(124, 263);
            this.txt_employee_biography.Multiline = true;
            this.txt_employee_biography.Name = "txt_employee_biography";
            this.txt_employee_biography.Size = new System.Drawing.Size(284, 63);
            this.txt_employee_biography.TabIndex = 82;
            this.txt_employee_biography.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(120, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Køn:";
            // 
            // cbb_employee_roles
            // 
            this.cbb_employee_roles.FormattingEnabled = true;
            this.cbb_employee_roles.Items.AddRange(new object[] {
            "Medarbejder",
            "Ejer"});
            this.cbb_employee_roles.Location = new System.Drawing.Point(125, 351);
            this.cbb_employee_roles.Name = "cbb_employee_roles";
            this.cbb_employee_roles.Size = new System.Drawing.Size(150, 21);
            this.cbb_employee_roles.TabIndex = 88;
            // 
            // lbl_employee_roles
            // 
            this.lbl_employee_roles.AutoSize = true;
            this.lbl_employee_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_roles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_roles.Location = new System.Drawing.Point(122, 335);
            this.lbl_employee_roles.Name = "lbl_employee_roles";
            this.lbl_employee_roles.Size = new System.Drawing.Size(40, 13);
            this.lbl_employee_roles.TabIndex = 87;
            this.lbl_employee_roles.Text = "Rolle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(122, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Adgangskode:";
            // 
            // txt_employee_password
            // 
            this.txt_employee_password.Location = new System.Drawing.Point(126, 396);
            this.txt_employee_password.Name = "txt_employee_password";
            this.txt_employee_password.Size = new System.Drawing.Size(176, 20);
            this.txt_employee_password.TabIndex = 89;
            this.txt_employee_password.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_create.Location = new System.Drawing.Point(124, 456);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 92;
            this.btn_create.Text = "Opret";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(452, 521);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_employee_password);
            this.Controls.Add(this.cbb_employee_roles);
            this.Controls.Add(this.lbl_employee_roles);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.lbl_employee_biography);
            this.Controls.Add(this.txt_employee_biography);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_employee_exp);
            this.Controls.Add(this.lbl_employee_exp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_employee_phoneno);
            this.Controls.Add(this.lbl_employee_email);
            this.Controls.Add(this.txt_employee_email);
            this.Controls.Add(this.lbl_employee_lastname);
            this.Controls.Add(this.txt_employee_lastname);
            this.Controls.Add(this.lbl_employee_firstname);
            this.Controls.Add(this.txt_employee_firstname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewEmployeeForm";
            this.Text = "NewEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.num_employee_exp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_employee_exp;
        private System.Windows.Forms.Label lbl_employee_exp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_employee_phoneno;
        private System.Windows.Forms.Label lbl_employee_email;
        private System.Windows.Forms.TextBox txt_employee_email;
        private System.Windows.Forms.Label lbl_employee_lastname;
        private System.Windows.Forms.TextBox txt_employee_lastname;
        private System.Windows.Forms.Label lbl_employee_firstname;
        private System.Windows.Forms.TextBox txt_employee_firstname;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Label lbl_employee_biography;
        private System.Windows.Forms.TextBox txt_employee_biography;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_employee_roles;
        private System.Windows.Forms.Label lbl_employee_roles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_employee_password;
        private System.Windows.Forms.Button btn_create;
    }
}