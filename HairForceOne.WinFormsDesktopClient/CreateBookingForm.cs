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

// implementer User
// ændring af navne
namespace HairForceOne.WinFormsDesktopClient
{
    public partial class CreateBookingForm : Form
    {
        ServicesController servicesController = new ServicesController();
        ProductsController productsController = new ProductsController();
        EmployeesController employeeController = new EmployeesController();
        BookingsController bookingsController = new BookingsController();
        //UsersController usersController = new UsersController();
        public CreateBookingForm()
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
            foreach (Service service in servicesController.GetAllServices())
            {
                ListViewItem i = new ListViewItem();
                i.Tag = service;
                i.Text = service.Title;
                i.ToolTipText = service.Price.ToString();
                lv_services.Items.Add(i);
            }
            foreach (Product product in productsController.GetAllProducts())
            {
                ListViewItem i = new ListViewItem();
                i.Tag = product;
                i.Text = product.Title;
                i.ToolTipText = product.RetailPrice.ToString();
                lv_products.Items.Add(i);
            }

        }
        private void lists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lb_employee.SelectedIndex > -1 && lv_services.CheckedItems.Count > 0 && dateTimePicker.Value >= DateTime.Now.AddHours(-1))
            {
                Event ev = new Event(dateTimePicker.Value, getDuration(), ((Employee)lb_employee.SelectedItem).EmployeeId);
                lb_availabletimes.DataSource = bookingsController.GetAvailableTimes(ev);
            }
            else
            {
                btn_createBooking.Enabled = false;
                lb_availabletimes.DataSource = null;
            }
        }

        private void lv_services_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            lists_SelectedIndexChanged(null, EventArgs.Empty);
        }

        private void lb_availabletimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_createBooking.Enabled = true;
        }

        // gennemgå metode
        private void btn_createBooking_Click(object sender, EventArgs e)
        {
            List<Service> services = new List<Service>();
            List<Product> products = new List<Product>();
            DateTime selectedDate = dateTimePicker.Value.Date.AddTicks(((TimeSpan)lb_availabletimes.SelectedItem).Ticks);
            foreach (ListViewItem item in lv_services.CheckedItems)
            {
                services.Add((Service)item.Tag);
            }
            foreach (ListViewItem item in lv_products.CheckedItems)
            {
                products.Add((Product)item.Tag);
            }
            Booking booking = new Booking(products.FirstOrDefault().ProductId, services.FirstOrDefault().ServiceId, 1, ((Employee)lb_employee.SelectedItem).EmployeeId, selectedDate, getDuration(), GetTotalPrice(), "Dette er en test kommentar fra DesktopClient");
            bookingsController.Create(booking);
            lb_availabletimes.DataSource = null;
            foreach (ListViewItem service in lv_services.CheckedItems)
            {
                service.Checked = false;
            }
            foreach (ListViewItem product in lv_products.CheckedItems)
            {
                product.Checked = false;
            }
            btn_createBooking.Enabled = false;
        }
        private int getDuration()
        {
            int duration = 0;
            foreach (ListViewItem service in lv_services.CheckedItems)
            {
                Service service2 = (Service)service.Tag;
                duration += service2.Duration;
            }
            return duration;
        }
        private decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (ListViewItem service in lv_services.CheckedItems)
            {
                Service service2 = (Service)service.Tag;
                totalPrice += service2.Price;
            }
            foreach (ListViewItem item in lv_products.CheckedItems)
            {
                Product product = (Product)item.Tag;
                totalPrice += product.RetailPrice;
            }
            return totalPrice;
        }
    }
}
