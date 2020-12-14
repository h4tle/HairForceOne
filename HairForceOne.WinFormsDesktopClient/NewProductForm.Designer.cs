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
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_product_gender = new System.Windows.Forms.Label();
            this.lbl_purchasePrice = new System.Windows.Forms.Label();
            this.txt_purchaseprice = new System.Windows.Forms.TextBox();
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
            this.rb_female.Location = new System.Drawing.Point(223, 312);
            this.rb_female.Margin = new System.Windows.Forms.Padding(2);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(58, 17);
            this.rb_female.TabIndex = 90;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Kvinde";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(101, 312);
            this.rb_male.Margin = new System.Windows.Forms.Padding(2);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(52, 17);
            this.rb_male.TabIndex = 89;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Mand";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_create.Enabled = false;
            this.btn_create.Location = new System.Drawing.Point(401, 424);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
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
            this.lbl_product_gender.Location = new System.Drawing.Point(100, 281);
            this.lbl_product_gender.Name = "lbl_product_gender";
            this.lbl_product_gender.Size = new System.Drawing.Size(45, 20);
            this.lbl_product_gender.TabIndex = 84;
            this.lbl_product_gender.Text = "Køn:";
            // 
            // lbl_purchasePrice
            // 
            this.lbl_purchasePrice.AutoSize = true;
            this.lbl_purchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_purchasePrice.Location = new System.Drawing.Point(100, 213);
            this.lbl_purchasePrice.Name = "lbl_purchasePrice";
            this.lbl_purchasePrice.Size = new System.Drawing.Size(108, 20);
            this.lbl_purchasePrice.TabIndex = 83;
            this.lbl_purchasePrice.Text = "IndkøbsPris:";
            // 
            // txt_purchaseprice
            // 
            this.txt_purchaseprice.Location = new System.Drawing.Point(100, 245);
            this.txt_purchaseprice.Name = "txt_purchaseprice";
            this.txt_purchaseprice.Size = new System.Drawing.Size(133, 20);
            this.txt_purchaseprice.TabIndex = 82;
            this.txt_purchaseprice.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_product_description
            // 
            this.lbl_product_description.AutoSize = true;
            this.lbl_product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_product_description.Location = new System.Drawing.Point(100, 136);
            this.lbl_product_description.Name = "lbl_product_description";
            this.lbl_product_description.Size = new System.Drawing.Size(100, 20);
            this.lbl_product_description.TabIndex = 79;
            this.lbl_product_description.Text = "Beskrivelse";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(100, 168);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(284, 20);
            this.txt_description.TabIndex = 78;
            this.txt_description.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_title.Location = new System.Drawing.Point(100, 70);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(54, 20);
            this.lbl_title.TabIndex = 77;
            this.lbl_title.Text = "Navn:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(100, 102);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(284, 20);
            this.txt_title.TabIndex = 76;
            this.txt_title.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_brand.Location = new System.Drawing.Point(100, 6);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(69, 20);
            this.lbl_brand.TabIndex = 75;
            this.lbl_brand.Text = "Mærke:";
            // 
            // txt_brand
            // 
            this.txt_brand.Location = new System.Drawing.Point(100, 38);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(284, 20);
            this.txt_brand.TabIndex = 74;
            this.txt_brand.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // lbl_retailprice
            // 
            this.lbl_retailprice.AutoSize = true;
            this.lbl_retailprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_retailprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_retailprice.Location = new System.Drawing.Point(251, 213);
            this.lbl_retailprice.Name = "lbl_retailprice";
            this.lbl_retailprice.Size = new System.Drawing.Size(44, 20);
            this.lbl_retailprice.TabIndex = 92;
            this.lbl_retailprice.Text = "Pris:";
            // 
            // txt_retailprice
            // 
            this.txt_retailprice.Location = new System.Drawing.Point(251, 245);
            this.txt_retailprice.Name = "txt_retailprice";
            this.txt_retailprice.Size = new System.Drawing.Size(133, 20);
            this.txt_retailprice.TabIndex = 91;
            this.txt_retailprice.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(533, 457);
            this.Controls.Add(this.lbl_retailprice);
            this.Controls.Add(this.txt_retailprice);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_product_gender);
            this.Controls.Add(this.lbl_purchasePrice);
            this.Controls.Add(this.txt_purchaseprice);
            this.Controls.Add(this.lbl_product_description);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.txt_brand);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewProductForm";
            this.Text = "NewProductForm";
            this.Load += new System.EventHandler(this.NewProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_product_gender;
        private System.Windows.Forms.Label lbl_purchasePrice;
        private System.Windows.Forms.TextBox txt_purchaseprice;
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