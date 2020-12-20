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
            lb_Products.DisplayMember = "Title";
            lb_Services.DisplayMember = "Title";
            cb_employee.DataSource = employeeController.GetEmployees();
            cb_employee.DisplayMember = "FirstName";
            dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
            //dgv_bookings.DataSource = bookingsController.GetAllBookings();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)dgv_bookings.CurrentRow.DataBoundItem;
            bookingsController.Delete(booking.BookingId);
            dgv_bookings.ClearSelection();
            dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
            if (dgv_bookings.Rows.Count <= 0)
            {
                lb_Services.DataSource = null;
                lb_Products.DataSource = null;
            }
        }

        private void dateTime1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);

            if (dgv_bookings.Rows.Count <= 0)
            {
                lb_Services.DataSource = null;
                lb_Products.DataSource = null;
            }
        }

        private void cb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
            if (dgv_bookings.Rows.Count <= 0)
            {
                lb_Services.DataSource = null;
                lb_Products.DataSource = null;
            }
        }

        private void dgv_bookings_SelectionChanged(object sender, EventArgs e)
        {
            if (btn_edit.Checked)
            {
                btn_edit.Checked = false;
                dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
            }
            if (dgv_bookings.Rows.Count <= 0)
            {
                lb_Services.DataSource = null;
                lb_Products.DataSource = null;
            }
            else
            {
                lb_Products.DataSource = ((Booking)dgv_bookings.CurrentRow.DataBoundItem).Products;
                lb_Services.DataSource = ((Booking)dgv_bookings.CurrentRow.DataBoundItem).Services;
                lb_Products.DisplayMember = "Title";
                lb_Services.DisplayMember = "Title";
            }
            //if (dgv_bookings.SelectedRows.Count > 0)
            //{
            //    lb_Services.DataSource = ((Booking)dgv_bookings.SelectedRows[0].DataBoundItem).Services;
            //    lb_Products.DataSource = ((Booking)dgv_bookings.SelectedRows[0].DataBoundItem).Products;
            //    lb_Products.DisplayMember = "Title";
            //    lb_Services.DisplayMember = "Title";
            //}
            //else
            //{
            //    lb_Services.DataSource = null;
            //    lb_Products.DataSource = null;
            //}
        }

        private void btn_backtomain_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void BookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)dgv_bookings.CurrentRow.DataBoundItem;
            Form checkoutForm = new CheckoutForm(booking);
            checkoutForm.Owner = this;
            checkoutForm.Show();
            this.Hide();
        }

        private void btn_edit_CheckedChanged(object sender, EventArgs e)
        {
            if (dgv_bookings.Rows.Count > 0)
            {
                if (btn_edit.Checked)
                {
                    dgv_bookings.ReadOnly = false;
                    Btn_SaveEdit.Enabled = true;
                    DataGridViewCell cell = dgv_bookings[1, dgv_bookings.CurrentRow.Index];
                    dgv_bookings.CurrentCell = cell;
                    dgv_bookings.BeginEdit(true);
                    btn_checkout.Enabled = false;
                    Btn_addProduct.Visible = true;
                    Btn_addService.Visible = true;
                    Btn_deleteService.Visible = true;
                    Btn_deleteProduct.Visible = true;
                }
                else
                {
                    dgv_bookings.ReadOnly = true;
                    Btn_SaveEdit.Enabled = false;
                    btn_checkout.Enabled = true;
                    Btn_addProduct.Visible = false;
                    Btn_addService.Visible = false;
                    Btn_deleteService.Visible = false;
                    Btn_deleteProduct.Visible = false;
                }
            }
        }

        private void Btn_SaveEdit_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)dgv_bookings.CurrentRow.DataBoundItem;
            if (bookingsController.Edit(booking))
            {
                dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
                if (dgv_bookings.Rows.Count <= 0)
                {
                    lb_Services.DataSource = null;
                    lb_Products.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Bookingen kunne ikke opdateres prøv igen.", "Opdater Booking",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_bookings_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Btn_deleteService_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)dgv_bookings.CurrentRow.DataBoundItem;
            for (int i = 0; i < booking.Services.Count; i++)
            {
                if (((Service)lb_Services.SelectedItem).Equals(booking.Services[i]))
                {
                    booking.Services.RemoveAt(i);
                }
            }
            lb_Services.DataSource = null;
            lb_Services.DataSource = ((Booking)dgv_bookings.CurrentRow.DataBoundItem).Services;
            lb_Services.DisplayMember = "Title";
        }

        private void dgv_bookings_ReadOnlyChanged(object sender, EventArgs e)
        {
            if (dgv_bookings.ReadOnly)
            {
                //dgv_bookings.DataSource = bookingsController.GetBookingsByEmployee((Employee)cb_employee.SelectedItem, dateTime1.SelectionStart);
            }
        }

        private void Btn_addService_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm();
            addServiceForm.Owner = this;
            addServiceForm.Show();
        }

        internal void addNewService(Service service)
        {
            Booking booking = (Booking)dgv_bookings.CurrentRow.DataBoundItem;
            booking.Services.Add(service);
            lb_Services.DataSource = null;
            lb_Services.DataSource = ((Booking)dgv_bookings.CurrentRow.DataBoundItem).Services;
            lb_Services.DisplayMember = "Title";
        }

        internal void addNewProduct(Product product)
        {
            Booking booking = (Booking)dgv_bookings.CurrentRow.DataBoundItem;
            booking.Products.Add(product);
            lb_Products.DataSource = null;
            lb_Products.DataSource = ((Booking)dgv_bookings.CurrentRow.DataBoundItem).Products;
            lb_Products.DisplayMember = "Title";
        }

        private void Btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Owner = this;
            addProductForm.Show();
        }

        private void Btn_deleteProduct_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)dgv_bookings.CurrentRow.DataBoundItem;
            for (int i = 0; i < booking.Products.Count; i++)
            {
                if (((Product)lb_Products.SelectedItem).Equals(booking.Products[i]))
                {
                    booking.Products.RemoveAt(i);
                }
            }
            lb_Products.DataSource = null;
            lb_Products.DataSource = ((Booking)dgv_bookings.CurrentRow.DataBoundItem).Products;
            lb_Products.DisplayMember = "Title";
        }
    }
}