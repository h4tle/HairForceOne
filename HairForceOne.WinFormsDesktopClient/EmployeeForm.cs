﻿using HairForceOne.WinFormsDesktopClient.Controller;
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
    public partial class EmployeeForm : Form
    {
        EmployeesController employeesController = new EmployeesController();
        Employee selectedEmployee;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = employeesController.GetEmployees();
            listBox1.DisplayMember = "FirstName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                selectedEmployee = (Employee) listBox1.SelectedItem;
                txt_employee_biography.Text = selectedEmployee.Biography;
                txt_employee_email.Text = selectedEmployee.Email;
                txt_employee_firstname.Text = selectedEmployee.FirstName;
                txt_employee_lastname.Text = selectedEmployee.LastName;
                txt_employee_password.Text = "";
                txt_employee_phoneno.Text = selectedEmployee.PhoneNo;
                num_employee_exp.Value = selectedEmployee.Experience;

                if (selectedEmployee.Roles == "admin")
                {
                    cbb_employee_roles.SelectedIndex = 0;
                }
                else
                {
                    cbb_employee_roles.SelectedIndex = 1;
                }

                if (selectedEmployee.Gender == "Female")
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
            String role = "";
            if (cbb_employee_roles.SelectedIndex == 0)
            {
                role = "admin";
            }
            else
            {
                role = "owner";
            }
            if (string.IsNullOrWhiteSpace(txt_employee_password.Text))
            {
                txt_employee_password.Text = null;
            }
            Employee employee = new Employee(selectedEmployee.EmployeeId, txt_employee_firstname.Text, txt_employee_lastname.Text, txt_employee_email.Text, txt_employee_phoneno.Text, (int) num_employee_exp.Value, malefemale, selectedEmployee.ProfilePicture, txt_employee_biography.Text, txt_employee_password.Text, selectedEmployee.Salt, role);
            employeesController.Update(employee);
            ReloadForm();
        }

        private void ReloadForm()
        {
            txt_employee_firstname.Clear();
            txt_employee_lastname.Clear();
            txt_employee_email.Clear();
            txt_employee_phoneno.Clear();
            num_employee_exp.ResetText();
            rb_female.Checked = false;
            rb_male.Checked = false;
            txt_employee_biography.Clear();
            cbb_employee_roles.ResetText();
            txt_employee_password.Clear();
            listBox1.SelectedIndex = -1;
            listBox1.DataSource = null;
            listBox1.DataSource = employeesController.GetEmployees();
            listBox1.DisplayMember = "FirstName";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            employeesController.Delete(selectedEmployee.EmployeeId);
            ReloadForm();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Form f = new NewEmployeeForm(employeesController);
            f.FormClosed += F2_FormClosed;
            f.ShowDialog();
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadForm();
        }
    }
}
