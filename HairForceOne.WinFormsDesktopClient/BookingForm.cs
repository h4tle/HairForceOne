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
    // ændring af navne

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
            lb_Products.DisplayMember = "Title";
            lb_Services.DisplayMember = "Title";
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
            dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem,dateTime1.SelectionStart);

        }

        private void cb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
        }

        private void dgv_bookings_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_bookings.SelectedRows.Count > 0)
            {
            lb_Services.DataSource = ((Booking)dgv_bookings.SelectedRows[0].DataBoundItem).Services;
            lb_Products.DataSource = ((Booking)dgv_bookings.SelectedRows[0].DataBoundItem).Products;
                lb_Products.DisplayMember = "Title";
                lb_Services.DisplayMember = "Title";
            }
            else
            {
                lb_Services.DataSource = null;
                lb_Products.DataSource = null;
            }
        }
    }
}
