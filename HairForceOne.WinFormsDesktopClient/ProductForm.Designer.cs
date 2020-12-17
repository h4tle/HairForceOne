namespace HairForceOne.WinFormsDesktopClient
{
    partial class ProductForm
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
            this.lbl_brand = new System.Windows.Forms.Label();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_product_description = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_product_gender = new System.Windows.Forms.Label();
            this.Btn_Create_Product = new System.Windows.Forms.Button();
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
            this.btn_backtomain.TabIndex = 29;
            this.btn_backtomain.Text = "Tilbage";
            this.btn_backtomain.UseVisualStyleBackColor = false;
            this.btn_backtomain.Click += new System.EventHandler(this.btn_backtomain_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_update.Location = new System.Drawing.Point(627, 632);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 35);
            this.btn_update.TabIndex = 31;
            this.btn_update.Text = "Rediger";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_delete.Location = new System.Drawing.Point(506, 632);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 35);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "Slet";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_brand.Location = new System.Drawing.Point(916, 223);
            this.lbl_brand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(100, 29);
            this.lbl_brand.TabIndex = 39;
            this.lbl_brand.Text = "Mærke:";
            // 
            // txt_brand
            // 
            this.txt_brand.Location = new System.Drawing.Point(916, 272);
            this.txt_brand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(424, 26);
            this.txt_brand.TabIndex = 38;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_title.Location = new System.Drawing.Point(916, 322);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(79, 29);
            this.lbl_title.TabIndex = 41;
            this.lbl_title.Text = "Navn:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(916, 371);
            this.txt_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(424, 26);
            this.txt_title.TabIndex = 40;
            // 
            // lbl_product_description
            // 
            this.lbl_product_description.AutoSize = true;
            this.lbl_product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_product_description.Location = new System.Drawing.Point(916, 423);
            this.lbl_product_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_description.Name = "lbl_product_description";
            this.lbl_product_description.Size = new System.Drawing.Size(149, 29);
            this.lbl_product_description.TabIndex = 43;
            this.lbl_product_description.Text = "Beskrivelse";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(916, 472);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(424, 26);
            this.txt_description.TabIndex = 42;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_price.Location = new System.Drawing.Point(916, 528);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(66, 29);
            this.lbl_price.TabIndex = 47;
            this.lbl_price.Text = "Pris:";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(916, 577);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(424, 26);
            this.txt_price.TabIndex = 46;
            // 
            // lbl_product_gender
            // 
            this.lbl_product_gender.AutoSize = true;
            this.lbl_product_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_product_gender.Location = new System.Drawing.Point(916, 632);
            this.lbl_product_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_product_gender.Name = "lbl_product_gender";
            this.lbl_product_gender.Size = new System.Drawing.Size(66, 29);
            this.lbl_product_gender.TabIndex = 48;
            this.lbl_product_gender.Text = "Køn:";
            // 
            // Btn_Create_Product
            // 
            this.Btn_Create_Product.BackColor = System.Drawing.Color.Lime;
            this.Btn_Create_Product.Location = new System.Drawing.Point(456, 751);
            this.Btn_Create_Product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Create_Product.Name = "Btn_Create_Product";
            this.Btn_Create_Product.Size = new System.Drawing.Size(238, 51);
            this.Btn_Create_Product.TabIndex = 50;
            this.Btn_Create_Product.Text = "Opret nyt Produkt";
            this.Btn_Create_Product.UseVisualStyleBackColor = false;
            this.Btn_Create_Product.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(243, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(494, 384);
            this.listBox1.TabIndex = 71;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(918, 680);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(74, 24);
            this.rb_male.TabIndex = 72;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Mand";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(1101, 680);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(81, 24);
            this.rb_female.TabIndex = 73;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Kvinde";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1512, 1049);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Btn_Create_Product);
            this.Controls.Add(this.lbl_product_gender);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_product_description);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_backtomain);
            this.Controls.Add(this.lbl_mainheader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mainheader;
        private System.Windows.Forms.Button btn_backtomain;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.TextBox txt_brand;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_product_description;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_product_gender;
        private System.Windows.Forms.Button Btn_Create_Product;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
    }
}