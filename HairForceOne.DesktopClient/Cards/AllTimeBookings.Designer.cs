namespace HairForceOne.DesktopClient
{
    public partial class AllTimeBookings
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
            this.FlowLayoutListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEmployees = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitAllTimeBookings)).BeginInit();
            this.splitAllTimeBookings.Panel1.SuspendLayout();
            this.splitAllTimeBookings.Panel2.SuspendLayout();
            this.splitAllTimeBookings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 1024);
            this.panel2.TabIndex = 0;
            // 
            // FlowLayoutListPanel
            // 
            this.FlowLayoutListPanel.AutoScroll = true;
            this.FlowLayoutListPanel.BackColor = System.Drawing.Color.DimGray;
            this.FlowLayoutListPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowLayoutListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutListPanel.Location = new System.Drawing.Point(0, 57);
            this.FlowLayoutListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutListPanel.Name = "FlowLayoutListPanel";
            this.FlowLayoutListPanel.Padding = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.FlowLayoutListPanel.Size = new System.Drawing.Size(1226, 967);
            this.FlowLayoutListPanel.TabIndex = 3;
            this.FlowLayoutListPanel.WrapContents = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(27, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 29);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Tidsbestillinger";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.FlowLayoutListPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 1024);
            this.panel1.TabIndex = 4;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitAllTimeBookings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEmployees;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.FlowLayoutPanel FlowLayoutListPanel;
        private System.Windows.Forms.Panel panel1;
    }
}
