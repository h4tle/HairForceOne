namespace HairForceOne.WinFormsDesktopClient
{
    partial class CheckoutForm
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
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.lbl_event = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lbl_booking_name = new System.Windows.Forms.Label();
            this.lbl_booking_employee = new System.Windows.Forms.Label();
            this.lbl_booking_services = new System.Windows.Forms.Label();
            this.lbl_booking_products = new System.Windows.Forms.Label();
            this.btn_backtomain = new System.Windows.Forms.Button();
            this.Lb_Products = new System.Windows.Forms.ListBox();
            this.Lb_Services = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_user.Location = new System.Drawing.Point(77, 166);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(176, 29);
            this.lbl_user.TabIndex = 14;
            this.lbl_user.Text = "Hjalmer Larsen";
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee.Location = new System.Drawing.Point(77, 279);
            this.lbl_employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(121, 29);
            this.lbl_employee.TabIndex = 15;
            this.lbl_employee.Text = "Hans kæg";
            // 
            // lbl_event
            // 
            this.lbl_event.AutoSize = true;
            this.lbl_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_event.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_event.Location = new System.Drawing.Point(398, 700);
            this.lbl_event.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_event.Name = "lbl_event";
            this.lbl_event.Size = new System.Drawing.Size(242, 29);
            this.lbl_event.TabIndex = 18;
            this.lbl_event.Text = "2020-12-01 11:30:000";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_price.Location = new System.Drawing.Point(477, 782);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(72, 29);
            this.lbl_price.TabIndex = 19;
            this.lbl_price.Text = "445 ,-";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_duration.Location = new System.Drawing.Point(477, 740);
            this.lbl_duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(84, 29);
            this.lbl_duration.TabIndex = 20;
            this.lbl_duration.Text = "60 min";
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_checkout.Location = new System.Drawing.Point(436, 816);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(140, 35);
            this.btn_checkout.TabIndex = 21;
            this.btn_checkout.Text = "Afslut handel";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.Btn_checkout_Click);
            // 
            // lbl_booking_name
            // 
            this.lbl_booking_name.AutoSize = true;
            this.lbl_booking_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_name.Location = new System.Drawing.Point(31, 109);
            this.lbl_booking_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_booking_name.Name = "lbl_booking_name";
            this.lbl_booking_name.Size = new System.Drawing.Size(99, 33);
            this.lbl_booking_name.TabIndex = 22;
            this.lbl_booking_name.Text = "Navn: ";
            // 
            // lbl_booking_employee
            // 
            this.lbl_booking_employee.AutoSize = true;
            this.lbl_booking_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_employee.Location = new System.Drawing.Point(31, 220);
            this.lbl_booking_employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_booking_employee.Name = "lbl_booking_employee";
            this.lbl_booking_employee.Size = new System.Drawing.Size(186, 33);
            this.lbl_booking_employee.TabIndex = 23;
            this.lbl_booking_employee.Text = "Medarbejder:";
            // 
            // lbl_booking_services
            // 
            this.lbl_booking_services.AutoSize = true;
            this.lbl_booking_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_services.Location = new System.Drawing.Point(31, 331);
            this.lbl_booking_services.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_booking_services.Name = "lbl_booking_services";
            this.lbl_booking_services.Size = new System.Drawing.Size(226, 33);
            this.lbl_booking_services.TabIndex = 24;
            this.lbl_booking_services.Text = "Valgte Services:";
            // 
            // lbl_booking_products
            // 
            this.lbl_booking_products.AutoSize = true;
            this.lbl_booking_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_products.Location = new System.Drawing.Point(31, 564);
            this.lbl_booking_products.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_booking_products.Name = "lbl_booking_products";
            this.lbl_booking_products.Size = new System.Drawing.Size(239, 33);
            this.lbl_booking_products.TabIndex = 25;
            this.lbl_booking_products.Text = "Valgte Produkter:";
            // 
            // btn_backtomain
            // 
            this.btn_backtomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_backtomain.Location = new System.Drawing.Point(18, 18);
            this.btn_backtomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_backtomain.Name = "btn_backtomain";
            this.btn_backtomain.Size = new System.Drawing.Size(112, 35);
            this.btn_backtomain.TabIndex = 27;
            this.btn_backtomain.Text = "Tilbage";
            this.btn_backtomain.UseVisualStyleBackColor = false;
            this.btn_backtomain.Click += new System.EventHandler(this.Btn_backtomain_Click);
            // 
            // Lb_Products
            // 
            this.Lb_Products.FormattingEnabled = true;
            this.Lb_Products.ItemHeight = 20;
            this.Lb_Products.Location = new System.Drawing.Point(37, 612);
            this.Lb_Products.Name = "Lb_Products";
            this.Lb_Products.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Lb_Products.Size = new System.Drawing.Size(220, 244);
            this.Lb_Products.TabIndex = 28;
            // 
            // Lb_Services
            // 
            this.Lb_Services.FormattingEnabled = true;
            this.Lb_Services.ItemHeight = 20;
            this.Lb_Services.Location = new System.Drawing.Point(37, 377);
            this.Lb_Services.Name = "Lb_Services";
            this.Lb_Services.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Lb_Services.Size = new System.Drawing.Size(220, 164);
            this.Lb_Services.TabIndex = 29;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(653, 888);
            this.Controls.Add(this.Lb_Services);
            this.Controls.Add(this.Lb_Products);
            this.Controls.Add(this.btn_backtomain);
            this.Controls.Add(this.lbl_booking_products);
            this.Controls.Add(this.lbl_booking_services);
            this.Controls.Add(this.lbl_booking_employee);
            this.Controls.Add(this.lbl_booking_name);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_event);
            this.Controls.Add(this.lbl_employee);
            this.Controls.Add(this.lbl_user);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckoutForm";
            this.Text = "BookingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckoutForm_FormClosed);
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.Label lbl_event;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label lbl_booking_name;
        private System.Windows.Forms.Label lbl_booking_employee;
        private System.Windows.Forms.Label lbl_booking_services;
        private System.Windows.Forms.Label lbl_booking_products;
        private System.Windows.Forms.Button btn_backtomain;
        private System.Windows.Forms.ListBox Lb_Products;
        private System.Windows.Forms.ListBox Lb_Services;
    }
}