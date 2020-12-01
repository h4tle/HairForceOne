namespace HairForceOne.WinFormsDesktopClient
{
    partial class EmployeeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_employee_firstname = new System.Windows.Forms.Label();
            this.txt_employee_firstname = new System.Windows.Forms.TextBox();
            this.lbl_employee_lastname = new System.Windows.Forms.Label();
            this.txt_employee_lastname = new System.Windows.Forms.TextBox();
            this.lbl_employee_email = new System.Windows.Forms.Label();
            this.txt_employee_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_employee_phoneno = new System.Windows.Forms.TextBox();
            this.cbb_employee_exp = new System.Windows.Forms.ComboBox();
            this.lbl_employee_exp = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_employee_picture = new System.Windows.Forms.Label();
            this.txt_employee_picture = new System.Windows.Forms.TextBox();
            this.lbl_employee_biography = new System.Windows.Forms.Label();
            this.txt_employee_biography = new System.Windows.Forms.TextBox();
            this.txt_employee_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_password_generate = new System.Windows.Forms.Button();
            this.cbb_employee_roles = new System.Windows.Forms.ComboBox();
            this.lbl_employee_roles = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_employee_upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mainheader
            // 
            this.lbl_mainheader.AutoSize = true;
            this.lbl_mainheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mainheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_mainheader.Location = new System.Drawing.Point(353, 42);
            this.lbl_mainheader.Name = "lbl_mainheader";
            this.lbl_mainheader.Size = new System.Drawing.Size(338, 55);
            this.lbl_mainheader.TabIndex = 10;
            this.lbl_mainheader.Text = "HairForceOne";
            // 
            // btn_backtomain
            // 
            this.btn_backtomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_backtomain.Location = new System.Drawing.Point(12, 12);
            this.btn_backtomain.Name = "btn_backtomain";
            this.btn_backtomain.Size = new System.Drawing.Size(75, 23);
            this.btn_backtomain.TabIndex = 30;
            this.btn_backtomain.Text = "Tilbage";
            this.btn_backtomain.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 436);
            this.dataGridView1.TabIndex = 31;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_update.Location = new System.Drawing.Point(381, 589);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 32;
            this.btn_update.Text = "Rediger";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_delete.Location = new System.Drawing.Point(471, 589);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 33;
            this.btn_delete.Text = "Slet";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // lbl_employee_firstname
            // 
            this.lbl_employee_firstname.AutoSize = true;
            this.lbl_employee_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_firstname.Location = new System.Drawing.Point(607, 125);
            this.lbl_employee_firstname.Name = "lbl_employee_firstname";
            this.lbl_employee_firstname.Size = new System.Drawing.Size(57, 13);
            this.lbl_employee_firstname.TabIndex = 41;
            this.lbl_employee_firstname.Text = "Fornavn:";
            // 
            // txt_employee_firstname
            // 
            this.txt_employee_firstname.Location = new System.Drawing.Point(610, 141);
            this.txt_employee_firstname.Name = "txt_employee_firstname";
            this.txt_employee_firstname.Size = new System.Drawing.Size(284, 20);
            this.txt_employee_firstname.TabIndex = 40;
            // 
            // lbl_employee_lastname
            // 
            this.lbl_employee_lastname.AutoSize = true;
            this.lbl_employee_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_lastname.Location = new System.Drawing.Point(607, 164);
            this.lbl_employee_lastname.Name = "lbl_employee_lastname";
            this.lbl_employee_lastname.Size = new System.Drawing.Size(66, 13);
            this.lbl_employee_lastname.TabIndex = 43;
            this.lbl_employee_lastname.Text = "Efternavn:";
            // 
            // txt_employee_lastname
            // 
            this.txt_employee_lastname.Location = new System.Drawing.Point(610, 180);
            this.txt_employee_lastname.Name = "txt_employee_lastname";
            this.txt_employee_lastname.Size = new System.Drawing.Size(284, 20);
            this.txt_employee_lastname.TabIndex = 42;
            // 
            // lbl_employee_email
            // 
            this.lbl_employee_email.AutoSize = true;
            this.lbl_employee_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_email.Location = new System.Drawing.Point(607, 203);
            this.lbl_employee_email.Name = "lbl_employee_email";
            this.lbl_employee_email.Size = new System.Drawing.Size(37, 13);
            this.lbl_employee_email.TabIndex = 45;
            this.lbl_employee_email.Text = "Email";
            // 
            // txt_employee_email
            // 
            this.txt_employee_email.Location = new System.Drawing.Point(610, 219);
            this.txt_employee_email.Name = "txt_employee_email";
            this.txt_employee_email.Size = new System.Drawing.Size(284, 20);
            this.txt_employee_email.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(607, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Telefonnummer:";
            // 
            // txt_employee_phoneno
            // 
            this.txt_employee_phoneno.Location = new System.Drawing.Point(610, 258);
            this.txt_employee_phoneno.Name = "txt_employee_phoneno";
            this.txt_employee_phoneno.Size = new System.Drawing.Size(284, 20);
            this.txt_employee_phoneno.TabIndex = 46;
            // 
            // cbb_employee_exp
            // 
            this.cbb_employee_exp.FormattingEnabled = true;
            this.cbb_employee_exp.Location = new System.Drawing.Point(610, 297);
            this.cbb_employee_exp.Name = "cbb_employee_exp";
            this.cbb_employee_exp.Size = new System.Drawing.Size(150, 21);
            this.cbb_employee_exp.TabIndex = 51;
            // 
            // lbl_employee_exp
            // 
            this.lbl_employee_exp.AutoSize = true;
            this.lbl_employee_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_exp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_exp.Location = new System.Drawing.Point(607, 281);
            this.lbl_employee_exp.Name = "lbl_employee_exp";
            this.lbl_employee_exp.Size = new System.Drawing.Size(55, 13);
            this.lbl_employee_exp.TabIndex = 50;
            this.lbl_employee_exp.Text = "Erfaring:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(610, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(607, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Køn:";
            // 
            // lbl_employee_picture
            // 
            this.lbl_employee_picture.AutoSize = true;
            this.lbl_employee_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_picture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_picture.Location = new System.Drawing.Point(607, 361);
            this.lbl_employee_picture.Name = "lbl_employee_picture";
            this.lbl_employee_picture.Size = new System.Drawing.Size(81, 13);
            this.lbl_employee_picture.TabIndex = 55;
            this.lbl_employee_picture.Text = "Billede: ????";
            // 
            // txt_employee_picture
            // 
            this.txt_employee_picture.Location = new System.Drawing.Point(610, 377);
            this.txt_employee_picture.Name = "txt_employee_picture";
            this.txt_employee_picture.Size = new System.Drawing.Size(176, 20);
            this.txt_employee_picture.TabIndex = 54;
            // 
            // lbl_employee_biography
            // 
            this.lbl_employee_biography.AutoSize = true;
            this.lbl_employee_biography.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_biography.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_biography.Location = new System.Drawing.Point(607, 403);
            this.lbl_employee_biography.Name = "lbl_employee_biography";
            this.lbl_employee_biography.Size = new System.Drawing.Size(58, 13);
            this.lbl_employee_biography.TabIndex = 57;
            this.lbl_employee_biography.Text = "Biografi: ";
            // 
            // txt_employee_biography
            // 
            this.txt_employee_biography.Location = new System.Drawing.Point(610, 419);
            this.txt_employee_biography.Name = "txt_employee_biography";
            this.txt_employee_biography.Size = new System.Drawing.Size(284, 20);
            this.txt_employee_biography.TabIndex = 56;
            // 
            // txt_employee_password
            // 
            this.txt_employee_password.Location = new System.Drawing.Point(610, 543);
            this.txt_employee_password.Name = "txt_employee_password";
            this.txt_employee_password.Size = new System.Drawing.Size(176, 20);
            this.txt_employee_password.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(607, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Adgangskode:";
            // 
            // btn_password_generate
            // 
            this.btn_password_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_password_generate.Location = new System.Drawing.Point(819, 541);
            this.btn_password_generate.Name = "btn_password_generate";
            this.btn_password_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_password_generate.TabIndex = 60;
            this.btn_password_generate.Text = "Generere";
            this.btn_password_generate.UseVisualStyleBackColor = false;
            // 
            // cbb_employee_roles
            // 
            this.cbb_employee_roles.FormattingEnabled = true;
            this.cbb_employee_roles.Location = new System.Drawing.Point(610, 500);
            this.cbb_employee_roles.Name = "cbb_employee_roles";
            this.cbb_employee_roles.Size = new System.Drawing.Size(150, 21);
            this.cbb_employee_roles.TabIndex = 62;
            // 
            // lbl_employee_roles
            // 
            this.lbl_employee_roles.AutoSize = true;
            this.lbl_employee_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_roles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_roles.Location = new System.Drawing.Point(607, 484);
            this.lbl_employee_roles.Name = "lbl_employee_roles";
            this.lbl_employee_roles.Size = new System.Drawing.Size(40, 13);
            this.lbl_employee_roles.TabIndex = 61;
            this.lbl_employee_roles.Text = "Rolle:";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_create.Location = new System.Drawing.Point(897, 589);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 63;
            this.btn_create.Text = "Opret";
            this.btn_create.UseVisualStyleBackColor = false;
            // 
            // btn_employee_upload
            // 
            this.btn_employee_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_employee_upload.Location = new System.Drawing.Point(819, 375);
            this.btn_employee_upload.Name = "btn_employee_upload";
            this.btn_employee_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_employee_upload.TabIndex = 64;
            this.btn_employee_upload.Text = "Upload";
            this.btn_employee_upload.UseVisualStyleBackColor = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_employee_upload);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.cbb_employee_roles);
            this.Controls.Add(this.lbl_employee_roles);
            this.Controls.Add(this.btn_password_generate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_employee_password);
            this.Controls.Add(this.lbl_employee_biography);
            this.Controls.Add(this.txt_employee_biography);
            this.Controls.Add(this.lbl_employee_picture);
            this.Controls.Add(this.txt_employee_picture);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_employee_exp);
            this.Controls.Add(this.lbl_employee_exp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_employee_phoneno);
            this.Controls.Add(this.lbl_employee_email);
            this.Controls.Add(this.txt_employee_email);
            this.Controls.Add(this.lbl_employee_lastname);
            this.Controls.Add(this.txt_employee_lastname);
            this.Controls.Add(this.lbl_employee_firstname);
            this.Controls.Add(this.txt_employee_firstname);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_backtomain);
            this.Controls.Add(this.lbl_mainheader);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mainheader;
        private System.Windows.Forms.Button btn_backtomain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_employee_firstname;
        private System.Windows.Forms.TextBox txt_employee_firstname;
        private System.Windows.Forms.Label lbl_employee_lastname;
        private System.Windows.Forms.TextBox txt_employee_lastname;
        private System.Windows.Forms.Label lbl_employee_email;
        private System.Windows.Forms.TextBox txt_employee_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_employee_phoneno;
        private System.Windows.Forms.ComboBox cbb_employee_exp;
        private System.Windows.Forms.Label lbl_employee_exp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_employee_picture;
        private System.Windows.Forms.TextBox txt_employee_picture;
        private System.Windows.Forms.Label lbl_employee_biography;
        private System.Windows.Forms.TextBox txt_employee_biography;
        private System.Windows.Forms.TextBox txt_employee_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_password_generate;
        private System.Windows.Forms.ComboBox cbb_employee_roles;
        private System.Windows.Forms.Label lbl_employee_roles;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_employee_upload;
    }
}