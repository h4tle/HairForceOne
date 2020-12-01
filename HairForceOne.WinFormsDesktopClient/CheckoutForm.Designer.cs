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
            this.lbl_mainheader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.lbl_services = new System.Windows.Forms.Label();
            this.lbl_products = new System.Windows.Forms.Label();
            this.lbl_event = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lbl_booking_name = new System.Windows.Forms.Label();
            this.lbl_booking_employee = new System.Windows.Forms.Label();
            this.lbl_booking_services = new System.Windows.Forms.Label();
            this.lbl_booking_products = new System.Windows.Forms.Label();
            this.lbl_booking_event = new System.Windows.Forms.Label();
            this.btn_backtomain = new System.Windows.Forms.Button();
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
            this.lbl_mainheader.TabIndex = 8;
            this.lbl_mainheader.Text = "HairForceOne";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 436);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_delete.Location = new System.Drawing.Point(471, 589);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Slet";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_update.Location = new System.Drawing.Point(381, 589);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Rediger";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_user.Location = new System.Drawing.Point(641, 170);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(116, 20);
            this.lbl_user.TabIndex = 14;
            this.lbl_user.Text = "Hjalmer Larsen";
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_employee.Location = new System.Drawing.Point(641, 237);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(83, 20);
            this.lbl_employee.TabIndex = 15;
            this.lbl_employee.Text = "Hans kæg";
            // 
            // lbl_services
            // 
            this.lbl_services.AutoSize = true;
            this.lbl_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_services.Location = new System.Drawing.Point(641, 305);
            this.lbl_services.Name = "lbl_services";
            this.lbl_services.Size = new System.Drawing.Size(179, 20);
            this.lbl_services.TabIndex = 16;
            this.lbl_services.Text = "Herreklip, Skægtrimning";
            // 
            // lbl_products
            // 
            this.lbl_products.AutoSize = true;
            this.lbl_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_products.Location = new System.Drawing.Point(641, 389);
            this.lbl_products.Name = "lbl_products";
            this.lbl_products.Size = new System.Drawing.Size(350, 20);
            this.lbl_products.TabIndex = 17;
            this.lbl_products.Text = "American Crew - Forming Cream Hair Wax 85 gr.";
            // 
            // lbl_event
            // 
            this.lbl_event.AutoSize = true;
            this.lbl_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_event.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_event.Location = new System.Drawing.Point(641, 468);
            this.lbl_event.Name = "lbl_event";
            this.lbl_event.Size = new System.Drawing.Size(166, 20);
            this.lbl_event.TabIndex = 18;
            this.lbl_event.Text = "2020-12-01 11:30:000";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_price.Location = new System.Drawing.Point(896, 543);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(49, 20);
            this.lbl_price.TabIndex = 19;
            this.lbl_price.Text = "445 ,-";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_duration.Location = new System.Drawing.Point(889, 513);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(56, 20);
            this.lbl_duration.TabIndex = 20;
            this.lbl_duration.Text = "60 min";
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_checkout.Location = new System.Drawing.Point(852, 589);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(93, 23);
            this.btn_checkout.TabIndex = 21;
            this.btn_checkout.Text = "Afslut handel";
            this.btn_checkout.UseVisualStyleBackColor = false;
            // 
            // lbl_booking_name
            // 
            this.lbl_booking_name.AutoSize = true;
            this.lbl_booking_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_name.Location = new System.Drawing.Point(611, 127);
            this.lbl_booking_name.Name = "lbl_booking_name";
            this.lbl_booking_name.Size = new System.Drawing.Size(64, 24);
            this.lbl_booking_name.TabIndex = 22;
            this.lbl_booking_name.Text = "Navn: ";
            // 
            // lbl_booking_employee
            // 
            this.lbl_booking_employee.AutoSize = true;
            this.lbl_booking_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_employee.Location = new System.Drawing.Point(611, 199);
            this.lbl_booking_employee.Name = "lbl_booking_employee";
            this.lbl_booking_employee.Size = new System.Drawing.Size(123, 24);
            this.lbl_booking_employee.TabIndex = 23;
            this.lbl_booking_employee.Text = "Medarbejder:";
            // 
            // lbl_booking_services
            // 
            this.lbl_booking_services.AutoSize = true;
            this.lbl_booking_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_services.Location = new System.Drawing.Point(611, 271);
            this.lbl_booking_services.Name = "lbl_booking_services";
            this.lbl_booking_services.Size = new System.Drawing.Size(145, 24);
            this.lbl_booking_services.TabIndex = 24;
            this.lbl_booking_services.Text = "Valgte Services:";
            // 
            // lbl_booking_products
            // 
            this.lbl_booking_products.AutoSize = true;
            this.lbl_booking_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_products.Location = new System.Drawing.Point(611, 347);
            this.lbl_booking_products.Name = "lbl_booking_products";
            this.lbl_booking_products.Size = new System.Drawing.Size(154, 24);
            this.lbl_booking_products.TabIndex = 25;
            this.lbl_booking_products.Text = "Valgte Produkter:";
            // 
            // lbl_booking_event
            // 
            this.lbl_booking_event.AutoSize = true;
            this.lbl_booking_event.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booking_event.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_booking_event.Location = new System.Drawing.Point(607, 428);
            this.lbl_booking_event.Name = "lbl_booking_event";
            this.lbl_booking_event.Size = new System.Drawing.Size(100, 24);
            this.lbl_booking_event.TabIndex = 26;
            this.lbl_booking_event.Text = "Valgte Tid:";
            // 
            // btn_backtomain
            // 
            this.btn_backtomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_backtomain.Location = new System.Drawing.Point(12, 12);
            this.btn_backtomain.Name = "btn_backtomain";
            this.btn_backtomain.Size = new System.Drawing.Size(75, 23);
            this.btn_backtomain.TabIndex = 27;
            this.btn_backtomain.Text = "Tilbage";
            this.btn_backtomain.UseVisualStyleBackColor = false;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_backtomain);
            this.Controls.Add(this.lbl_booking_event);
            this.Controls.Add(this.lbl_booking_products);
            this.Controls.Add(this.lbl_booking_services);
            this.Controls.Add(this.lbl_booking_employee);
            this.Controls.Add(this.lbl_booking_name);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_event);
            this.Controls.Add(this.lbl_products);
            this.Controls.Add(this.lbl_services);
            this.Controls.Add(this.lbl_employee);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_mainheader);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mainheader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.Label lbl_services;
        private System.Windows.Forms.Label lbl_products;
        private System.Windows.Forms.Label lbl_event;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label lbl_booking_name;
        private System.Windows.Forms.Label lbl_booking_employee;
        private System.Windows.Forms.Label lbl_booking_services;
        private System.Windows.Forms.Label lbl_booking_products;
        private System.Windows.Forms.Label lbl_booking_event;
        private System.Windows.Forms.Button btn_backtomain;
    }
}