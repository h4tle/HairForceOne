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
        //UsersController usersController = new UsersController();
        public BookingForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            lb_employee.DataSource = employeeController.GetEmployees();
            lb_employee.DisplayMember = "FirstName";
            foreach (Service service in servicesController.GetServices())
            {
                ListViewItem i = new ListViewItem();
                i.Tag = service;
                i.Text = service.Title;
                i.ToolTipText = service.Price.ToString();
                listView1.Items.Add(i);
            }
            foreach (Product product in productsController.GetProducts())
            {
                ListViewItem i = new ListViewItem();
                i.Tag = product;
                i.Text = product.Title;
                i.ToolTipText = product.RetailPrice.ToString();
                listView2.Items.Add(i);
            }

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            lb_availabletimes.DataSource = null;
        }

        private void lb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
