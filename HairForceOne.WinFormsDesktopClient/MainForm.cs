using HairForceOne.WinFormsDesktopClient.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Too much FullScreen
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_main_next_Click(object sender, EventArgs e)
        {

        }

        private void lbl_main_watch_Click(object sender, EventArgs e)
        {

        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {

            lbl_main_watch.Text = DateTime.Now.ToString("g");
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            Form serviceForm = new ServiceForm();
            serviceForm.Show();
            this.Hide();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Form productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }
    }
}
