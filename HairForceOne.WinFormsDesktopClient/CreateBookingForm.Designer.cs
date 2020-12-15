namespace HairForceOne.WinFormsDesktopClient
{
    partial class CreateBookingForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lb_availabletimes = new System.Windows.Forms.ListBox();
            this.lb_users = new System.Windows.Forms.ListBox();
            this.lb_employee = new System.Windows.Forms.ListBox();
            this.lv_services = new System.Windows.Forms.ListView();
            this.lv_products = new System.Windows.Forms.ListView();
            this.btn_createBooking = new System.Windows.Forms.Button();
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
            this.lbl_mainheader.TabIndex = 10;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 682);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(839, 33);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker.TabIndex = 33;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.lists_SelectedIndexChanged);
            // 
            // lb_availabletimes
            // 
            this.lb_availabletimes.FormattingEnabled = true;
            this.lb_availabletimes.Location = new System.Drawing.Point(839, 55);
            this.lb_availabletimes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_availabletimes.Name = "lb_availabletimes";
            this.lb_availabletimes.Size = new System.Drawing.Size(135, 225);
            this.lb_availabletimes.TabIndex = 34;
            this.lb_availabletimes.SelectedIndexChanged += new System.EventHandler(this.lb_availabletimes_SelectedIndexChanged);
            // 
            // lb_users
            // 
            this.lb_users.FormattingEnabled = true;
            this.lb_users.Location = new System.Drawing.Point(475, 33);
            this.lb_users.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(179, 173);
            this.lb_users.TabIndex = 35;
            // 
            // lb_employee
            // 
            this.lb_employee.FormattingEnabled = true;
            this.lb_employee.Location = new System.Drawing.Point(669, 33);
            this.lb_employee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_employee.Name = "lb_employee";
            this.lb_employee.Size = new System.Drawing.Size(160, 173);
            this.lb_employee.TabIndex = 36;
            this.lb_employee.SelectedIndexChanged += new System.EventHandler(this.lists_SelectedIndexChanged);
            // 
            // lv_services
            // 
            this.lv_services.CheckBoxes = true;
            this.lv_services.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_services.HideSelection = false;
            this.lv_services.Location = new System.Drawing.Point(85, 33);
            this.lv_services.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lv_services.MultiSelect = false;
            this.lv_services.Name = "lv_services";
            this.lv_services.Size = new System.Drawing.Size(169, 168);
            this.lv_services.TabIndex = 37;
            this.lv_services.UseCompatibleStateImageBehavior = false;
            this.lv_services.View = System.Windows.Forms.View.List;
            this.lv_services.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_services_ItemChecked);
            // 
            // lv_products
            // 
            this.lv_products.CheckBoxes = true;
            this.lv_products.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_products.HideSelection = false;
            this.lv_products.Location = new System.Drawing.Point(287, 33);
            this.lv_products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(169, 168);
            this.lv_products.TabIndex = 38;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.List;
            // 
            // btn_createBooking
            // 
            this.btn_createBooking.BackColor = System.Drawing.Color.Lime;
            this.btn_createBooking.Enabled = false;
            this.btn_createBooking.Location = new System.Drawing.Point(466, 287);
            this.btn_createBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_createBooking.Name = "btn_createBooking";
            this.btn_createBooking.Size = new System.Drawing.Size(117, 40);
            this.btn_createBooking.TabIndex = 39;
            this.btn_createBooking.Text = "Opret Booking";
            this.btn_createBooking.UseVisualStyleBackColor = false;
            this.btn_createBooking.Click += new System.EventHandler(this.btn_createBooking_Click);
            // 
            // CreateBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.btn_createBooking);
            this.Controls.Add(this.lv_products);
            this.Controls.Add(this.lv_services);
            this.Controls.Add(this.lb_employee);
            this.Controls.Add(this.lb_users);
            this.Controls.Add(this.lb_availabletimes);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_backtomain);
            this.Controls.Add(this.lbl_mainheader);
            this.Name = "CreateBookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mainheader;
        private System.Windows.Forms.Button btn_backtomain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox lb_availabletimes;
        private System.Windows.Forms.ListBox lb_users;
        private System.Windows.Forms.ListBox lb_employee;
        private System.Windows.Forms.ListView lv_services;
        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.Button btn_createBooking;
    }
}