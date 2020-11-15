namespace HairForceOne.DesktopClient
{
    partial class AllTimeBookings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitAllTimeBookings = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEmployees = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitAllTimeBookings)).BeginInit();
            this.splitAllTimeBookings.Panel1.SuspendLayout();
            this.splitAllTimeBookings.Panel2.SuspendLayout();
            this.splitAllTimeBookings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitAllTimeBookings
            // 
            this.splitAllTimeBookings.Location = new System.Drawing.Point(0, 0);
            this.splitAllTimeBookings.Margin = new System.Windows.Forms.Padding(0);
            this.splitAllTimeBookings.Name = "splitAllTimeBookings";
            // 
            // splitAllTimeBookings.Panel1
            // 
            this.splitAllTimeBookings.Panel1.Controls.Add(this.panel2);
            this.splitAllTimeBookings.Panel1MinSize = 0;
            // 
            // splitAllTimeBookings.Panel2
            // 
            this.splitAllTimeBookings.Panel2.AutoScroll = true;
            this.splitAllTimeBookings.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitAllTimeBookings.Panel2.Controls.Add(this.monthCalendar1);
            this.splitAllTimeBookings.Panel2.Controls.Add(this.label1);
            this.splitAllTimeBookings.Panel2.Controls.Add(this.comboEmployees);
            this.splitAllTimeBookings.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitAllTimeBookings.Panel2MinSize = 0;
            this.splitAllTimeBookings.Size = new System.Drawing.Size(1594, 1024);
            this.splitAllTimeBookings.SplitterDistance = 1226;
            this.splitAllTimeBookings.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 1024);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tidsbestillinger";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(15, 92);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboEmployees
            // 
            this.comboEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmployees.FormattingEnabled = true;
            this.comboEmployees.Location = new System.Drawing.Point(15, 40);
            this.comboEmployees.Margin = new System.Windows.Forms.Padding(10);
            this.comboEmployees.MinimumSize = new System.Drawing.Size(266, 0);
            this.comboEmployees.Name = "comboEmployees";
            this.comboEmployees.Size = new System.Drawing.Size(329, 33);
            this.comboEmployees.TabIndex = 0;
            this.comboEmployees.Text = "Medarbejder";
            // 
            // AllTimeBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitAllTimeBookings);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AllTimeBookings";
            this.Size = new System.Drawing.Size(1594, 1024);
            this.splitAllTimeBookings.Panel1.ResumeLayout(false);
            this.splitAllTimeBookings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAllTimeBookings)).EndInit();
            this.splitAllTimeBookings.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitAllTimeBookings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEmployees;
        private System.Windows.Forms.Label label2;
    }
}
