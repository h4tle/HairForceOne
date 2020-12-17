namespace HairForceOne.WinFormsDesktopClient
{
    partial class BookingForm
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
            this.dateTime1 = new System.Windows.Forms.MonthCalendar();
            this.dgv_bookings = new System.Windows.Forms.DataGridView();
            this.cb_employee = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.lb_Services = new System.Windows.Forms.ListBox();
            this.lb_Products = new System.Windows.Forms.ListBox();
            this.btn_backtomain = new System.Windows.Forms.Button();
            this.Btn_deleteService = new System.Windows.Forms.Button();
            this.Btn_deleteProduct = new System.Windows.Forms.Button();
            this.Btn_addService = new System.Windows.Forms.Button();
            this.Btn_addProduct = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.CheckBox();
            this.Btn_SaveEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime1
            // 
            this.dateTime1.BackColor = System.Drawing.SystemColors.Control;
            this.dateTime1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.dateTime1.Location = new System.Drawing.Point(25, 72);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.TabIndex = 3;
            this.dateTime1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateTime1_DateChanged);
            // 
            // dgv_bookings
            // 
            this.dgv_bookings.AllowUserToAddRows = false;
            this.dgv_bookings.AllowUserToDeleteRows = false;
            this.dgv_bookings.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_bookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookings.Location = new System.Drawing.Point(311, 106);
            this.dgv_bookings.MultiSelect = false;
            this.dgv_bookings.Name = "dgv_bookings";
            this.dgv_bookings.ReadOnly = true;
            this.dgv_bookings.RowHeadersWidth = 62;
            this.dgv_bookings.RowTemplate.Height = 28;
            this.dgv_bookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bookings.Size = new System.Drawing.Size(763, 437);
            this.dgv_bookings.TabIndex = 4;
            this.dgv_bookings.ReadOnlyChanged += new System.EventHandler(this.dgv_bookings_ReadOnlyChanged);
            this.dgv_bookings.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bookings_RowLeave);
            this.dgv_bookings.SelectionChanged += new System.EventHandler(this.dgv_bookings_SelectionChanged);
            // 
            // cb_employee
            // 
            this.cb_employee.FormattingEnabled = true;
            this.cb_employee.Location = new System.Drawing.Point(311, 72);
            this.cb_employee.Name = "cb_employee";
            this.cb_employee.Size = new System.Drawing.Size(199, 28);
            this.cb_employee.TabIndex = 5;
            this.cb_employee.SelectedIndexChanged += new System.EventHandler(this.cb_employee_SelectedIndexChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(311, 566);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 32);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Slet";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.Lime;
            this.btn_checkout.Location = new System.Drawing.Point(597, 566);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(98, 35);
            this.btn_checkout.TabIndex = 7;
            this.btn_checkout.Text = "Check ud";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // lb_Services
            // 
            this.lb_Services.FormattingEnabled = true;
            this.lb_Services.ItemHeight = 20;
            this.lb_Services.Location = new System.Drawing.Point(1132, 72);
            this.lb_Services.Name = "lb_Services";
            this.lb_Services.Size = new System.Drawing.Size(335, 204);
            this.lb_Services.TabIndex = 9;
            // 
            // lb_Products
            // 
            this.lb_Products.FormattingEnabled = true;
            this.lb_Products.ItemHeight = 20;
            this.lb_Products.Location = new System.Drawing.Point(1132, 413);
            this.lb_Products.Name = "lb_Products";
            this.lb_Products.Size = new System.Drawing.Size(335, 204);
            this.lb_Products.TabIndex = 10;
            // 
            // btn_backtomain
            // 
            this.btn_backtomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(167)))), ((int)(((byte)(122)))));
            this.btn_backtomain.Location = new System.Drawing.Point(25, 14);
            this.btn_backtomain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_backtomain.Name = "btn_backtomain";
            this.btn_backtomain.Size = new System.Drawing.Size(112, 35);
            this.btn_backtomain.TabIndex = 31;
            this.btn_backtomain.Text = "Tilbage";
            this.btn_backtomain.UseVisualStyleBackColor = false;
            this.btn_backtomain.Click += new System.EventHandler(this.btn_backtomain_Click);
            // 
            // Btn_deleteService
            // 
            this.Btn_deleteService.BackColor = System.Drawing.Color.Red;
            this.Btn_deleteService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_deleteService.Location = new System.Drawing.Point(1369, 282);
            this.Btn_deleteService.Name = "Btn_deleteService";
            this.Btn_deleteService.Size = new System.Drawing.Size(98, 35);
            this.Btn_deleteService.TabIndex = 32;
            this.Btn_deleteService.Text = "Slet";
            this.Btn_deleteService.UseVisualStyleBackColor = false;
            this.Btn_deleteService.Visible = false;
            this.Btn_deleteService.Click += new System.EventHandler(this.Btn_deleteService_Click);
            // 
            // Btn_deleteProduct
            // 
            this.Btn_deleteProduct.BackColor = System.Drawing.Color.Red;
            this.Btn_deleteProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_deleteProduct.Location = new System.Drawing.Point(1369, 623);
            this.Btn_deleteProduct.Name = "Btn_deleteProduct";
            this.Btn_deleteProduct.Size = new System.Drawing.Size(98, 35);
            this.Btn_deleteProduct.TabIndex = 33;
            this.Btn_deleteProduct.Text = "Slet";
            this.Btn_deleteProduct.UseVisualStyleBackColor = false;
            this.Btn_deleteProduct.Visible = false;
            // 
            // Btn_addService
            // 
            this.Btn_addService.Location = new System.Drawing.Point(1265, 282);
            this.Btn_addService.Name = "Btn_addService";
            this.Btn_addService.Size = new System.Drawing.Size(98, 35);
            this.Btn_addService.TabIndex = 34;
            this.Btn_addService.Text = "Tilføj";
            this.Btn_addService.UseVisualStyleBackColor = true;
            this.Btn_addService.Visible = false;
            // 
            // Btn_addProduct
            // 
            this.Btn_addProduct.Location = new System.Drawing.Point(1265, 623);
            this.Btn_addProduct.Name = "Btn_addProduct";
            this.Btn_addProduct.Size = new System.Drawing.Size(98, 35);
            this.Btn_addProduct.TabIndex = 35;
            this.Btn_addProduct.Text = "Tilføj";
            this.Btn_addProduct.UseVisualStyleBackColor = true;
            this.Btn_addProduct.Visible = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_edit.AutoSize = true;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_edit.Location = new System.Drawing.Point(872, 566);
            this.btn_edit.MinimumSize = new System.Drawing.Size(98, 35);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 35);
            this.btn_edit.TabIndex = 36;
            this.btn_edit.Text = "Rediger";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.CheckedChanged += new System.EventHandler(this.btn_edit_CheckedChanged);
            // 
            // Btn_SaveEdit
            // 
            this.Btn_SaveEdit.Enabled = false;
            this.Btn_SaveEdit.Location = new System.Drawing.Point(976, 566);
            this.Btn_SaveEdit.Name = "Btn_SaveEdit";
            this.Btn_SaveEdit.Size = new System.Drawing.Size(98, 35);
            this.Btn_SaveEdit.TabIndex = 37;
            this.Btn_SaveEdit.Text = "Gem";
            this.Btn_SaveEdit.UseVisualStyleBackColor = true;
            this.Btn_SaveEdit.Click += new System.EventHandler(this.Btn_SaveEdit_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1512, 1049);
            this.Controls.Add(this.Btn_SaveEdit);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.Btn_addProduct);
            this.Controls.Add(this.Btn_addService);
            this.Controls.Add(this.Btn_deleteProduct);
            this.Controls.Add(this.Btn_deleteService);
            this.Controls.Add(this.btn_backtomain);
            this.Controls.Add(this.lb_Products);
            this.Controls.Add(this.lb_Services);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cb_employee);
            this.Controls.Add(this.dgv_bookings);
            this.Controls.Add(this.dateTime1);
            this.Name = "BookingForm";
            this.Text = "Booking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookingForm_FormClosed);
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dateTime1;
        private System.Windows.Forms.DataGridView dgv_bookings;
        private System.Windows.Forms.ComboBox cb_employee;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.ListBox lb_Services;
        private System.Windows.Forms.ListBox lb_Products;
        private System.Windows.Forms.Button btn_backtomain;
        private System.Windows.Forms.Button Btn_deleteService;
        private System.Windows.Forms.Button Btn_deleteProduct;
        private System.Windows.Forms.Button Btn_addService;
        private System.Windows.Forms.Button Btn_addProduct;
        private System.Windows.Forms.CheckBox btn_edit;
        private System.Windows.Forms.Button Btn_SaveEdit;
    }
}