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
    public partial class AddServiceForm : Form
    {
            ServicesController servicesController = new ServicesController();
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
