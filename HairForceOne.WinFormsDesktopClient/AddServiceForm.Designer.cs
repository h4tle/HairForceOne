namespace HairForceOne.WinFormsDesktopClient
{
    partial class AddServiceForm
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
            this.Lb_services = new System.Windows.Forms.ListBox();
            this.Btn__Select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_services
            // 
            this.Lb_services.FormattingEnabled = true;
            this.Lb_services.ItemHeight = 20;
            this.Lb_services.Location = new System.Drawing.Point(25, 12);
            this.Lb_services.Name = "Lb_services";
            this.Lb_services.Size = new System.Drawing.Size(196, 264);
            this.Lb_services.TabIndex = 0;
            // 
            // Btn__Select
            // 
            this.Btn__Select.Location = new System.Drawing.Point(25, 282);
            this.Btn__Select.Name = "Btn__Select";
            this.Btn__Select.Size = new System.Drawing.Size(196, 38);
            this.Btn__Select.TabIndex = 2;
            this.Btn__Select.Text = "OK";
            this.Btn__Select.UseVisualStyleBackColor = true;
            this.Btn__Select.Click += new System.EventHandler(this.Btn__Select_Click);
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 366);
            this.Controls.Add(this.Btn__Select);
            this.Controls.Add(this.Lb_services);
            this.Name = "AddServiceForm";
            this.Text = "AddServiceForm";
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_services;
        private System.Windows.Forms.Button Btn__Select;
    }
}