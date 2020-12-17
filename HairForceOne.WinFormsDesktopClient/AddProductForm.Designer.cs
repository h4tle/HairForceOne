namespace HairForceOne.WinFormsDesktopClient
{
    partial class AddProductForm
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
            this.Btn_Select = new System.Windows.Forms.Button();
            this.Lb_products = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Btn_Select
            // 
            this.Btn_Select.Location = new System.Drawing.Point(25, 282);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(196, 38);
            this.Btn_Select.TabIndex = 4;
            this.Btn_Select.Text = "OK";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // Lb_products
            // 
            this.Lb_products.FormattingEnabled = true;
            this.Lb_products.ItemHeight = 20;
            this.Lb_products.Location = new System.Drawing.Point(25, 12);
            this.Lb_products.Name = "Lb_products";
            this.Lb_products.Size = new System.Drawing.Size(196, 264);
            this.Lb_products.TabIndex = 3;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 366);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.Lb_products);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.ListBox Lb_products;
    }
}