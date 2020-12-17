using HairForceOne.WinFormsDesktopClient.Model;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm(Booking booking)
        {
            InitializeComponent();
        }

        private void btn_backtomain_Click(object sender, System.EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void CheckoutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}