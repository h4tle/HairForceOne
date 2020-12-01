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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_product_description = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.cbb_gender = new System.Windows.Forms.ComboBox();
            this.lbl_product_gender = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_employee_upload = new System.Windows.Forms.Button();
            this.lbl_employee_picture = new System.Windows.Forms.Label();
            this.txt_employee_picture = new System.Windows.Forms.TextBox();
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
            this.lbl_mainheader.TabIndex = 9;
            this.lbl_mainheader.Text = "HairForceOne";
            // 
            // btn_backtomain
            // 
            this.btn_backtomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_backtomain.Location = new System.Drawing.Point(12, 12);
            this.btn_backtomain.Name = "btn_backtomain";
            this.btn_backtomain.Size = new System.Drawing.Size(75, 23);
            this.btn_backtomain.TabIndex = 29;
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
            this.dataGridView1.TabIndex = 30;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_update.Location = new System.Drawing.Point(381, 589);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 31;
            this.btn_update.Text = "Rediger";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_delete.Location = new System.Drawing.Point(471, 589);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "Slet";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_brand.Location = new System.Drawing.Point(611, 145);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(69, 20);
            this.lbl_brand.TabIndex = 39;
            this.lbl_brand.Text = "Mærke:";
            // 
            // txt_brand
            // 
            this.txt_brand.Location = new System.Drawing.Point(611, 177);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(284, 20);
            this.txt_brand.TabIndex = 38;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_title.Location = new System.Drawing.Point(611, 209);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(54, 20);
            this.lbl_title.TabIndex = 41;
            this.lbl_title.Text = "Navn:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(611, 241);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(284, 20);
            this.txt_title.TabIndex = 40;
            // 
            // lbl_product_description
            // 
            this.lbl_product_description.AutoSize = true;
            this.lbl_product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_product_description.Location = new System.Drawing.Point(611, 275);
            this.lbl_product_description.Name = "lbl_product_description";
            this.lbl_product_description.Size = new System.Drawing.Size(100, 20);
            this.lbl_product_description.TabIndex = 43;
            this.lbl_product_description.Text = "Beskrivelse";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(611, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 42;
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_weight.Location = new System.Drawing.Point(611, 346);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(63, 20);
            this.lbl_weight.TabIndex = 45;
            this.lbl_weight.Text = "Vægt: ";
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(611, 378);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(284, 20);
            this.txt_weight.TabIndex = 44;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_price.Location = new System.Drawing.Point(611, 413);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(44, 20);
            this.lbl_price.TabIndex = 47;
            this.lbl_price.Text = "Pris:";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(611, 445);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(284, 20);
            this.txt_price.TabIndex = 46;
            // 
            // cbb_gender
            // 
            this.cbb_gender.FormattingEnabled = true;
            this.cbb_gender.Location = new System.Drawing.Point(611, 504);
            this.cbb_gender.Name = "cbb_gender";
            this.cbb_gender.Size = new System.Drawing.Size(150, 21);
            this.cbb_gender.TabIndex = 49;
            // 
            // lbl_product_gender
            // 
            this.lbl_product_gender.AutoSize = true;
            this.lbl_product_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_product_gender.Location = new System.Drawing.Point(611, 481);
            this.lbl_product_gender.Name = "lbl_product_gender";
            this.lbl_product_gender.Size = new System.Drawing.Size(45, 20);
            this.lbl_product_gender.TabIndex = 48;
            this.lbl_product_gender.Text = "Køn:";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_create.Location = new System.Drawing.Point(897, 589);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 50;
            this.btn_create.Text = "Opret";
            this.btn_create.UseVisualStyleBackColor = false;
            // 
            // btn_employee_upload
            // 
            this.btn_employee_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_employee_upload.Location = new System.Drawing.Point(821, 564);
            this.btn_employee_upload.Name = "btn_employee_upload";
            this.btn_employee_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_employee_upload.TabIndex = 70;
            this.btn_employee_upload.Text = "Upload";
            this.btn_employee_upload.UseVisualStyleBackColor = false;
            // 
            // lbl_employee_picture
            // 
            this.lbl_employee_picture.AutoSize = true;
            this.lbl_employee_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_picture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee_picture.Location = new System.Drawing.Point(611, 543);
            this.lbl_employee_picture.Name = "lbl_employee_picture";
            this.lbl_employee_picture.Size = new System.Drawing.Size(113, 20);
            this.lbl_employee_picture.TabIndex = 69;
            this.lbl_employee_picture.Text = "Billede: ????";
            // 
            // txt_employee_picture
            // 
            this.txt_employee_picture.Location = new System.Drawing.Point(612, 566);
            this.txt_employee_picture.Name = "txt_employee_picture";
            this.txt_employee_picture.Size = new System.Drawing.Size(176, 20);
            this.txt_employee_picture.TabIndex = 68;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_employee_upload);
            this.Controls.Add(this.lbl_employee_picture);
            this.Controls.Add(this.txt_employee_picture);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.cbb_gender);
            this.Controls.Add(this.lbl_product_gender);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.lbl_product_description);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_backtomain);
            this.Controls.Add(this.lbl_mainheader);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
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
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.TextBox txt_brand;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_product_description;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ComboBox cbb_gender;
        private System.Windows.Forms.Label lbl_product_gender;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_employee_upload;
        private System.Windows.Forms.Label lbl_employee_picture;
        private System.Windows.Forms.TextBox txt_employee_picture;
    }
}