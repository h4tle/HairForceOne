using System;
using System.Windows.Forms;

// ændring af navne
// slet/implementer labels
// show/hide skal gennemgås (gøres det rigtigt?)
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
            lbl_main_watch.Text = DateTime.Now.ToString("t");
            // Too much FullScreen
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void Lbl_main_next_Click(object sender, EventArgs e)
        {
        }

        private void Lbl_main_watch_Click(object sender, EventArgs e)
        {
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lbl_main_watch.Text = DateTime.Now.ToString("t");
        }

        private void Btn_service_Click(object sender, EventArgs e)
        {
            Form serviceForm = new ServiceForm
            {
                Owner = this
            };
            serviceForm.Show();
            this.Hide();
        }

        private void Btn_product_Click(object sender, EventArgs e)
        {
            Form productForm = new ProductForm
            {
                Owner = this
            };
            productForm.Show();
            this.Hide();
        }

        private void Btn_employee_Click(object sender, EventArgs e)
        {
            Form employeeForm = new EmployeeForm
            {
                Owner = this
            };
            employeeForm.Show();
            this.Hide();
        }

        private void Btn_booking_Click(object sender, EventArgs e)
        {
            Form BookingForm = new BookingForm
            {
                Owner = this
            };
            BookingForm.Show();
            this.Hide();
        }

        private void Btn_createbooking_Click(object sender, EventArgs e)
        {
            Form CreateBookingForm = new CreateBookingForm
            {
                Owner = this
            };
            CreateBookingForm.Show();
            this.Hide();
        }

        private void Btn_user_Click(object sender, EventArgs e)
        {
            Form UserForm = new UserForm
            {
                Owner = this
            };
            UserForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.Owner.Visible)
            {
                Application.Exit();
            }
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}