using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
{
    public partial class AddServiceForm : Form
    {
        private ServicesController servicesController = new ServicesController();

        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            Lb_services.DataSource = servicesController.GetAllServices();
            Lb_services.DisplayMember = "Title";
        }

        private void Btn__Select_Click(object sender, EventArgs e)
        {
            var parent = (BookingForm)this.Owner;
            parent.addNewService((Service)Lb_services.SelectedItem);
            this.Close();
        }
    }
}