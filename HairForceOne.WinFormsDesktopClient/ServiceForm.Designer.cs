namespace HairForceOne.WinFormsDesktopClient
{
    partial class ServiceForm
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.Btn_create_Service = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_service_gender = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
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
            this.lbl_mainheader.TabIndex = 9;
            this.lbl_mainheader.Text = "HairForceOne";
            // 
            // btn_backtomain
            // 
            this.btn_backtomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_backtomain.Location = new System.Drawing.Point(18, 18);
            this.btn_backtomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_backtomain.Name = "btn_backtomain";
            this.btn_backtomain.Size = new System.Drawing.Size(112, 35);
            this.btn_backtomain.TabIndex = 28;
            this.btn_backtomain.Text = "Tilbage";
            this.btn_backtomain.UseVisualStyleBackColor = false;
            this.btn_backtomain.Click += new System.EventHandler(this.btn_backtomain_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_update.Location = new System.Drawing.Point(630, 688);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 35);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "Rediger";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_delete.Location = new System.Drawing.Point(508, 688);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 35);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Slet";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Btn_create_Service
            // 
            this.Btn_create_Service.BackColor = System.Drawing.Color.Lime;
            this.Btn_create_Service.Location = new System.Drawing.Point(456, 751);
            this.Btn_create_Service.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_create_Service.Name = "Btn_create_Service";
            this.Btn_create_Service.Size = new System.Drawing.Size(238, 51);
            this.Btn_create_Service.TabIndex = 32;
            this.Btn_create_Service.Text = "Opret ny Service";
            this.Btn_create_Service.UseVisualStyleBackColor = false;
            this.Btn_create_Service.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(916, 272);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 26);
            this.textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(916, 351);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(424, 44);
            this.textBox2.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(916, 438);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(424, 26);
            this.textBox3.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(916, 529);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(424, 26);
            this.textBox4.TabIndex = 36;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_title.Location = new System.Drawing.Point(916, 214);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(73, 29);
            this.lbl_title.TabIndex = 37;
            this.lbl_title.Text = "Titel:";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_description.Location = new System.Drawing.Point(916, 312);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(156, 29);
            this.lbl_description.TabIndex = 38;
            this.lbl_description.Text = "Beskrivelse:";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_Duration.Location = new System.Drawing.Point(916, 400);
            this.lbl_Duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(125, 29);
            this.lbl_Duration.TabIndex = 39;
            this.lbl_Duration.Text = "Varighed:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_price.Location = new System.Drawing.Point(916, 488);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(66, 29);
            this.lbl_price.TabIndex = 40;
            this.lbl_price.Text = "Pris:";
            // 
            // lbl_service_gender
            // 
            this.lbl_service_gender.AutoSize = true;
            this.lbl_service_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_service_gender.Location = new System.Drawing.Point(916, 585);
            this.lbl_service_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_service_gender.Name = "lbl_service_gender";
            this.lbl_service_gender.Size = new System.Drawing.Size(66, 29);
            this.lbl_service_gender.TabIndex = 41;
            this.lbl_service_gender.Text = "Køn:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(330, 214);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 444);
            this.listBox1.TabIndex = 43;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(921, 629);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(74, 24);
            this.rb_male.TabIndex = 44;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Mand";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(1078, 629);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(81, 24);
            this.rb_female.TabIndex = 45;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Kvinde";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1512, 1049);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_service_gender);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_create_Service);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_backtomain);
            this.Controls.Add(this.lbl_mainheader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceForm_FormClosed);
            this.Load += new System.EventHandler(this.ServiceForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mainheader;
        private System.Windows.Forms.Button btn_backtomain;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button Btn_create_Service;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_service_gender;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
    }
}