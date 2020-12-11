using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
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
    public partial class BookingForm : Form
    {
        ServicesController servicesController = new ServicesController();
        ProductsController productsController = new ProductsController();
        EmployeesController employeeController = new EmployeesController();
        BookingsController bookingsController = new BookingsController();
        //UsersController usersController = new UsersController();
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            var test1 = bookingsController.GetAllBookings();
            dgv_bookings.DataSource = test1;
            cb_employee.DataSource = employeeController.GetEmployees();
            cb_employee.DisplayMember = "FirstName";

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
            dgv_bookings.DataSource = bookingsController.GetBookingsById(dateTime1.SelectionStart);
        }
    }
}
