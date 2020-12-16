using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
// ændring af navne

{
    public partial class BookingForm : Form
    {
        private ServicesController servicesController = new ServicesController();
        private ProductsController productsController = new ProductsController();
        private EmployeesController employeeController = new EmployeesController();
        private BookingsController bookingsController = new BookingsController();

        //UsersController usersController = new UsersController();
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            cb_employee.DataSource = employeeController.GetEmployees();
            cb_employee.DisplayMember = "FirstName";
            //dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
            dgv_bookings.DataSource = bookingsController.GetAllBookings();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)dgv_bookings.CurrentRow.DataBoundItem;
            bookingsController.Delete(booking.BookingId);
            dgv_bookings.ClearSelection();
            dgv_bookings.DataSource = bookingsController.GetAllBookings();
        }

        private void dateTime1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
        }

        private void cb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
        }
    }
}