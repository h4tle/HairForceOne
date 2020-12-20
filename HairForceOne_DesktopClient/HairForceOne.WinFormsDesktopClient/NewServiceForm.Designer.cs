namespace HairForceOne.WinFormsDesktopClient
{
    partial class NewServiceForm
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
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.lbl_service_gender = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_service_price = new System.Windows.Forms.TextBox();
            this.txt_service_duration = new System.Windows.Forms.TextBox();
            this.txt_service_description = new System.Windows.Forms.TextBox();
            this.txt_service_title = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Checked = true;
            this.rb_female.Location = new System.Drawing.Point(234, 274);
            this.rb_female.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(58, 17);
            this.rb_female.TabIndex = 56;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Kvinde";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(129, 274);
            this.rb_male.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(52, 17);
            this.rb_male.TabIndex = 55;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Mand";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // lbl_service_gender
            // 
            this.lbl_service_gender.AutoSize = true;
            this.lbl_service_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_service_gender.Location = new System.Drawing.Point(125, 244);
            this.lbl_service_gender.Name = "lbl_service_gender";
            this.lbl_service_gender.Size = new System.Drawing.Size(45, 20);
            this.lbl_service_gender.TabIndex = 54;
            this.lbl_service_gender.Text = "Køn:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_price.Location = new System.Drawing.Point(125, 181);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(44, 20);
            this.lbl_price.TabIndex = 53;
            this.lbl_price.Text = "Pris:";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_Duration.Location = new System.Drawing.Point(125, 124);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(86, 20);
            this.lbl_Duration.TabIndex = 52;
            this.lbl_Duration.Text = "Varighed:";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_description.Location = new System.Drawing.Point(125, 67);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(105, 20);
            this.lbl_description.TabIndex = 51;
            this.lbl_description.Text = "Beskrivelse:";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_title.Location = new System.Drawing.Point(125, 3);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(48, 20);
            this.lbl_title.TabIndex = 50;
            this.lbl_title.Text = "Titel:";
            // 
            // txt_service_price
            // 
            this.txt_service_price.Location = new System.Drawing.Point(125, 208);
            this.txt_service_price.Name = "txt_service_price";
            this.txt_service_price.Size = new System.Drawing.Size(284, 20);
            this.txt_service_price.TabIndex = 49;
            this.txt_service_price.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // txt_service_duration
            // 
            this.txt_service_duration.Location = new System.Drawing.Point(125, 149);
            this.txt_service_duration.Name = "txt_service_duration";
            this.txt_service_duration.Size = new System.Drawing.Size(284, 20);
            this.txt_service_duration.TabIndex = 48;
            this.txt_service_duration.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // txt_service_description
            // 
            this.txt_service_description.Location = new System.Drawing.Point(125, 92);
            this.txt_service_description.Multiline = true;
            this.txt_service_description.Name = "txt_service_description";
            this.txt_service_description.Size = new System.Drawing.Size(284, 30);
            this.txt_service_description.TabIndex = 47;
            this.txt_service_description.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // txt_service_title
            // 
            this.txt_service_title.Location = new System.Drawing.Point(125, 41);
            this.txt_service_title.Name = "txt_service_title";
            this.txt_service_title.Size = new System.Drawing.Size(284, 20);
            this.txt_service_title.TabIndex = 46;
            this.txt_service_title.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_create.Enabled = false;
            this.btn_create.Location = new System.Drawing.Point(333, 266);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 57;
            this.btn_create.Text = "Opret";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // NewServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(533, 326);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.lbl_service_gender);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_service_price);
            this.Controls.Add(this.txt_service_duration);
            this.Controls.Add(this.txt_service_description);
            this.Controls.Add(this.txt_service_title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewServiceForm";
            this.Text = "NewServiceForm";
            this.Load += new System.EventHandler(this.NewServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Label lbl_service_gender;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_service_price;
        private System.Windows.Forms.TextBox txt_service_duration;
        private System.Windows.Forms.TextBox txt_service_description;
        private System.Windows.Forms.TextBox txt_service_title;
        private System.Windows.Forms.Button btn_create;
    }
}