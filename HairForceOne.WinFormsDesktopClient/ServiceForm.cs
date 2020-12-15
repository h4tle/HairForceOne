using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Windows.Forms;

// ændring af navne
namespace HairForceOne.WinFormsDesktopClient
{
    public partial class ServiceForm : Form
    {
        private ServicesController sc = new ServicesController();
        private Service selectedService;

        public ServiceForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ServiceForm_Load_1(object sender, EventArgs e)
        {
            listBox1.DataSource = sc.GetAllServices();
            //foreach (Service s in sc.GetServices())
            //{
            //    listBox1.Items.Add(s);
            //}
            listBox1.DisplayMember = "Title";
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                selectedService = (Service)listBox1.SelectedItem;
                textBox1.Text = selectedService.Title;
                textBox2.Text = selectedService.Description;
                textBox3.Text = selectedService.Duration.ToString();
                textBox4.Text = selectedService.Price.ToString();
                if (selectedService.Gender == "Female")
                {
                    rb_female.Checked = true;
                }
                else
                {
                    rb_male.Checked = true;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            String malefemale = "";
            if (rb_female.Checked)
            {
                malefemale = "Female";
            }
            else
            {
                malefemale = "Male";
            }
            Service s = new Service(selectedService.ServiceId, textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), decimal.Parse(textBox4.Text), malefemale);
            sc.EditService(s);
            ReloadForm();
        }

        private void ReloadForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            rb_female.Checked = false;
            rb_male.Checked = false;
            listBox1.SelectedIndex = -1;
            listBox1.DataSource = null;
            listBox1.DataSource = sc.GetAllServices();
            listBox1.DisplayMember = "Title";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sc.DeleteService(selectedService.ServiceId);
            ReloadForm();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Form f = new NewServiceForm(sc);
            f.FormClosed += F2_FormClosed;
            f.ShowDialog();
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadForm();
        }
    }
}