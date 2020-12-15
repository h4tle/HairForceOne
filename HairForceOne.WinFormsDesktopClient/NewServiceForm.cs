﻿using System;
using HairForceOne.WinFormsDesktopClient.Controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HairForceOne.WinFormsDesktopClient.Model;

// ændring af navne
// tjek om enable af create knap virker
namespace HairForceOne.WinFormsDesktopClient
{
    internal partial class NewServiceForm : Form
    {
        ServicesController sc;
        public NewServiceForm(ServicesController sc)
        {
            this.sc = sc;
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
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
            Service s = new Service(0, txt_service_title.Text, txt_service_description.Text, int.Parse(txt_service_duration.Text), decimal.Parse(txt_service_price.Text), malefemale);
            sc.CreateNewService(s);
            this.Close();
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void EnableButton()
        {
            btn_create.Enabled = !Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text));
        }

        private void NewServiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
