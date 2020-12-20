using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
{
    public partial class CheckoutForm : Form
    {
        private readonly BookingsController bookingController = new BookingsController();
        private readonly UsersController usersController = new UsersController();
        private readonly EmployeesController employeesController = new EmployeesController();
        private readonly Booking booking;

        public CheckoutForm(Booking booking)
        {
            this.booking = booking;
            InitializeComponent();
        }

        private void Btn_backtomain_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void CheckoutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void Btn_checkout_Click(object sender, System.EventArgs e)
        {
            bookingController.CheckOut(booking);
            this.Owner.Close();
        }

        private void CheckoutForm_Load(object sender, System.EventArgs e)
        {
            User user = usersController.GetUser(booking.UserId);
            Employee employee = employeesController.GetEmployee(booking.EmployeeId);
            Lb_Products.DataSource = booking.Products;
            Lb_Products.DisplayMember = "Title";

            Lb_Services.DataSource = booking.Services;
            Lb_Services.DisplayMember = "Title";

            lbl_employee.Text = employee.FirstName;
            lbl_user.Text = user.FirstName + " " + user.LastName;
            lbl_duration.Text = booking.Duration.ToString() + " min";
            lbl_price.Text = booking.TotalPrice.ToString() + "kr.";
            lbl_event.Text = booking.StartTime.ToString("g");
        }
    }
}