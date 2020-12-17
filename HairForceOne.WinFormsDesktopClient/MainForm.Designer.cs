namespace HairForceOne.WinFormsDesktopClient
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_service = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_mainheader = new System.Windows.Forms.Label();
            this.lbl_main_next = new System.Windows.Forms.Label();
            this.lbl_main_counter = new System.Windows.Forms.Label();
            this.lbl_main_watch = new System.Windows.Forms.Label();
            this.btn_createbooking = new System.Windows.Forms.Button();
            this.btn_booking = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(1266, 211);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(0);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(224, 346);
            this.btn_checkout.TabIndex = 0;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            // 
            // btn_service
            // 
            this.btn_service.Location = new System.Drawing.Point(268, 211);
            this.btn_service.Margin = new System.Windows.Forms.Padding(0);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(224, 346);
            this.btn_service.TabIndex = 1;
            this.btn_service.Text = "Service";
            this.btn_service.UseVisualStyleBackColor = true;
            this.btn_service.Click += new System.EventHandler(this.Btn_service_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(768, 211);
            this.btn_employee.Margin = new System.Windows.Forms.Padding(0);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(224, 346);
            this.btn_employee.TabIndex = 3;
            this.btn_employee.Text = "Employee";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.Btn_employee_Click);
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(518, 211);
            this.btn_product.Margin = new System.Windows.Forms.Padding(0);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(224, 346);
            this.btn_product.TabIndex = 2;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.Btn_product_Click);
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(1020, 211);
            this.btn_user.Margin = new System.Windows.Forms.Padding(0);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(224, 346);
            this.btn_user.TabIndex = 4;
            this.btn_user.Text = "User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.Btn_user_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(1346, 823);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(112, 35);
            this.btn_settings.TabIndex = 5;
            this.btn_settings.Text = "Indstillinger";
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_logout.Location = new System.Drawing.Point(1377, 18);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(112, 35);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Log ud";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
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
            this.lbl_mainheader.TabIndex = 7;
            this.lbl_mainheader.Text = "HairForceOne";
            // 
            // lbl_main_next
            // 
            this.lbl_main_next.AutoSize = true;
            this.lbl_main_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_main_next.Location = new System.Drawing.Point(46, 657);
            this.lbl_main_next.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_main_next.Name = "lbl_main_next";
            this.lbl_main_next.Size = new System.Drawing.Size(261, 25);
            this.lbl_main_next.TabIndex = 8;
            this.lbl_main_next.Text = "Næste kunde klokken: 12:30";
            this.lbl_main_next.Click += new System.EventHandler(this.Lbl_main_next_Click);
            // 
            // lbl_main_counter
            // 
            this.lbl_main_counter.AutoSize = true;
            this.lbl_main_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_counter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_main_counter.Location = new System.Drawing.Point(46, 700);
            this.lbl_main_counter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_main_counter.Name = "lbl_main_counter";
            this.lbl_main_counter.Size = new System.Drawing.Size(202, 25);
            this.lbl_main_counter.TabIndex = 9;
            this.lbl_main_counter.Text = "Antal kunder i dag: 14";
            // 
            // lbl_main_watch
            // 
            this.lbl_main_watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_watch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.lbl_main_watch.Location = new System.Drawing.Point(544, 774);
            this.lbl_main_watch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_main_watch.Name = "lbl_main_watch";
            this.lbl_main_watch.Size = new System.Drawing.Size(486, 252);
            this.lbl_main_watch.TabIndex = 10;
            this.lbl_main_watch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_main_watch.Click += new System.EventHandler(this.Lbl_main_watch_Click);
            // 
            // btn_createbooking
            // 
            this.btn_createbooking.BackColor = System.Drawing.Color.Lime;
            this.btn_createbooking.Location = new System.Drawing.Point(544, 686);
            this.btn_createbooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_createbooking.Name = "btn_createbooking";
            this.btn_createbooking.Size = new System.Drawing.Size(492, 54);
            this.btn_createbooking.TabIndex = 11;
            this.btn_createbooking.Text = "Opret Booking";
            this.btn_createbooking.UseVisualStyleBackColor = false;
            this.btn_createbooking.Click += new System.EventHandler(this.Btn_createbooking_Click);
            // 
            // btn_booking
            // 
            this.btn_booking.Location = new System.Drawing.Point(26, 211);
            this.btn_booking.Margin = new System.Windows.Forms.Padding(0);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(224, 346);
            this.btn_booking.TabIndex = 12;
            this.btn_booking.Text = "Booking";
            this.btn_booking.UseVisualStyleBackColor = true;
            this.btn_booking.Click += new System.EventHandler(this.Btn_booking_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 30000;
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1512, 1049);
            this.Controls.Add(this.btn_booking);
            this.Controls.Add(this.btn_createbooking);
            this.Controls.Add(this.lbl_main_watch);
            this.Controls.Add(this.lbl_main_counter);
            this.Controls.Add(this.lbl_main_next);
            this.Controls.Add(this.lbl_mainheader);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_service);
            this.Controls.Add(this.btn_checkout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_service;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_mainheader;
        private System.Windows.Forms.Label lbl_main_next;
        private System.Windows.Forms.Label lbl_main_counter;
        private System.Windows.Forms.Label lbl_main_watch;
        private System.Windows.Forms.Button btn_createbooking;
        private System.Windows.Forms.Button btn_booking;
        private System.Windows.Forms.Timer clockTimer;
    }
}