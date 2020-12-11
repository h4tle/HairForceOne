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
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime1
            // 
            this.dateTime1.BackColor = System.Drawing.SystemColors.Control;
            this.dateTime1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.dateTime1.Location = new System.Drawing.Point(18, 18);
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
            this.dgv_bookings.Location = new System.Drawing.Point(304, 52);
            this.dgv_bookings.MultiSelect = false;
            this.dgv_bookings.Name = "dgv_bookings";
            this.dgv_bookings.ReadOnly = true;
            this.dgv_bookings.RowHeadersWidth = 62;
            this.dgv_bookings.RowTemplate.Height = 28;
            this.dgv_bookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bookings.Size = new System.Drawing.Size(535, 437);
            this.dgv_bookings.TabIndex = 4;
            // 
            // cb_employee
            // 
            this.cb_employee.FormattingEnabled = true;
            this.cb_employee.Location = new System.Drawing.Point(304, 18);
            this.cb_employee.Name = "cb_employee";
            this.cb_employee.Size = new System.Drawing.Size(199, 28);
            this.cb_employee.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(304, 513);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(97, 32);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Slet";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.Lime;
            this.btn_checkout.Location = new System.Drawing.Point(742, 509);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(97, 36);
            this.btn_checkout.TabIndex = 7;
            this.btn_checkout.Text = "Check ud";
            this.btn_checkout.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(639, 509);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(97, 36);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Rediger";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 1050);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cb_employee);
            this.Controls.Add(this.dgv_bookings);
            this.Controls.Add(this.dateTime1);
            this.Name = "BookingForm";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dateTime1;
        private System.Windows.Forms.DataGridView dgv_bookings;
        private System.Windows.Forms.ComboBox cb_employee;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_edit;
    }
}