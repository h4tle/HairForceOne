namespace HairForceOne.WinFormsDesktopClient
{
    partial class NewProductForm
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
            this.btn_employee_upload = new System.Windows.Forms.Button();
            this.lbl_employee_picture = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_product_gender = new System.Windows.Forms.Label();
            this.lbl_purchasePrice = new System.Windows.Forms.Label();
            this.txt_purchaseprice = new System.Windows.Forms.TextBox();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.lbl_product_description = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.lbl_retailprice = new System.Windows.Forms.Label();
            this.txt_retailprice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Checked = true;
            this.rb_female.Location = new System.Drawing.Point(335, 574);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(81, 24);
            this.rb_female.TabIndex = 90;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Kvinde";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(152, 574);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(74, 24);
            this.rb_male.TabIndex = 89;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Mand";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // btn_employee_upload
            // 
            this.btn_employee_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_employee_upload.Location = new System.Drawing.Point(155, 653);
            this.btn_employee_upload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_employee_upload.Name = "btn_employee_upload";
            this.btn_employee_upload.Size = new System.Drawing.Size(112, 35);
            this.btn_employee_upload.TabIndex = 88;
            this.btn_employee_upload.Text = "Upload";
            this.btn_employee_upload.UseVisualStyleBackColor = false;
            // 
            // lbl_employee_picture
            // 
            this.lbl_employee_picture.AutoSize = true;
            this.lbl_employee_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_picture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_picture.Location = new System.Drawing.Point(150, 621);
            this.lbl_employee_picture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_employee_picture.Name = "lbl_employee_picture";
            this.lbl_employee_picture.Size = new System.Drawing.Size(162, 29);
            this.lbl_employee_picture.TabIndex = 87;
            this.lbl_employee_picture.Text = "Billede: ????";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_create.Enabled = false;
            this.btn_create.Location = new System.Drawing.Point(602, 653);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(112, 35);
            this.btn_create.TabIndex = 85;
            this.btn_create.Text = "Opret";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_product_gender
            // 
            this.lbl_product_gender.AutoSize = true;
            this.lbl_product_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_product_gender.Location = new System.Drawing.Point(150, 526);
            this.lbl_product_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_gender.Name = "lbl_product_gender";
            this.lbl_product_gender.Size = new System.Drawing.Size(66, 29);
            this.lbl_product_gender.TabIndex = 84;
            this.lbl_product_gender.Text = "Køn:";
            // 
            // lbl_purchasePrice
            // 
            this.lbl_purchasePrice.AutoSize = true;
            this.lbl_purchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_purchasePrice.Location = new System.Drawing.Point(150, 421);
            this.lbl_purchasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_purchasePrice.Name = "lbl_purchasePrice";
            this.lbl_purchasePrice.Size = new System.Drawing.Size(158, 29);
            this.lbl_purchasePrice.TabIndex = 83;
            this.lbl_purchasePrice.Text = "IndkøbsPris:";
            // 
            // txt_purchaseprice
            // 
            this.txt_purchaseprice.Location = new System.Drawing.Point(150, 471);
            this.txt_purchaseprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_purchaseprice.Name = "txt_purchaseprice";
            this.txt_purchaseprice.Size = new System.Drawing.Size(197, 26);
            this.txt_purchaseprice.TabIndex = 82;
            this.txt_purchaseprice.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_weight.Location = new System.Drawing.Point(150, 318);
            this.lbl_weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(87, 29);
            this.lbl_weight.TabIndex = 81;
            this.lbl_weight.Text = "Vægt: ";
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(150, 368);
            this.txt_weight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(424, 26);
            this.txt_weight.TabIndex = 80;
            this.txt_weight.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_product_description
            // 
            this.lbl_product_description.AutoSize = true;
            this.lbl_product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_product_description.Location = new System.Drawing.Point(150, 209);
            this.lbl_product_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_description.Name = "lbl_product_description";
            this.lbl_product_description.Size = new System.Drawing.Size(149, 29);
            this.lbl_product_description.TabIndex = 79;
            this.lbl_product_description.Text = "Beskrivelse";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(150, 258);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(424, 26);
            this.txt_description.TabIndex = 78;
            this.txt_description.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_title.Location = new System.Drawing.Point(150, 108);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(79, 29);
            this.lbl_title.TabIndex = 77;
            this.lbl_title.Text = "Navn:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(150, 157);
            this.txt_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(424, 26);
            this.txt_title.TabIndex = 76;
            this.txt_title.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_brand.Location = new System.Drawing.Point(150, 9);
            this.lbl_brand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(100, 29);
            this.lbl_brand.TabIndex = 75;
            this.lbl_brand.Text = "Mærke:";
            // 
            // txt_brand
            // 
            this.txt_brand.Location = new System.Drawing.Point(150, 58);
            this.txt_brand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(424, 26);
            this.txt_brand.TabIndex = 74;
            this.txt_brand.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_retailprice
            // 
            this.lbl_retailprice.AutoSize = true;
            this.lbl_retailprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_retailprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_retailprice.Location = new System.Drawing.Point(377, 421);
            this.lbl_retailprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_retailprice.Name = "lbl_retailprice";
            this.lbl_retailprice.Size = new System.Drawing.Size(66, 29);
            this.lbl_retailprice.TabIndex = 92;
            this.lbl_retailprice.Text = "Pris:";
            // 
            // txt_retailprice
            // 
            this.txt_retailprice.Location = new System.Drawing.Point(377, 471);
            this.txt_retailprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_retailprice.Name = "txt_retailprice";
            this.txt_retailprice.Size = new System.Drawing.Size(197, 26);
            this.txt_retailprice.TabIndex = 91;
            this.txt_retailprice.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.lbl_retailprice);
            this.Controls.Add(this.txt_retailprice);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.btn_employee_upload);
            this.Controls.Add(this.lbl_employee_picture);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_product_gender);
            this.Controls.Add(this.lbl_purchasePrice);
            this.Controls.Add(this.txt_purchaseprice);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.lbl_product_description);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.txt_brand);
            this.Name = "NewProductForm";
            this.Text = "NewProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Button btn_employee_upload;
        private System.Windows.Forms.Label lbl_employee_picture;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_product_gender;
        private System.Windows.Forms.Label lbl_purchasePrice;
        private System.Windows.Forms.TextBox txt_purchaseprice;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label lbl_product_description;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.TextBox txt_brand;
        private System.Windows.Forms.Label lbl_retailprice;
        private System.Windows.Forms.TextBox txt_retailprice;
    }
}