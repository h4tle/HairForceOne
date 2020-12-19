using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
{
    // ændring af navne
    // regex
    // tjek om enable af create knap virker
    internal partial class NewEmployeeForm : Form
    {
        private EmployeesController employeesController;

        public NewEmployeeForm(EmployeesController employeesController)
        {
            this.employeesController = employeesController;
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
            int role = 0;
            if (cbb_employee_roles.SelectedIndex == 0)
            {
                role = 2;
            }
            else
            {
                role = 3;
            }

            Employee employee = new Employee(0, txt_employee_firstname.Text, txt_employee_lastname.Text, txt_employee_email.Text, txt_employee_phoneno.Text, (int)num_employee_exp.Value, malefemale, txt_employee_biography.Text, role);
            employee.Password = txt_employee_password.Text;
            employeesController.CreateNewEmployee(employee);
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
    }
}