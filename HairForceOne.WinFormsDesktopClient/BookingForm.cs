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
            dgv_bookings.DataSource = bookingsController.GetAllBookings();
            cb_employee.DataSource = employeeController.GetEmployees();

        }
    }
}
