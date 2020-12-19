using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
{
    // ændring af navne
    // Regex

    public partial class EmployeeForm : Form
    {
        private EmployeesController employeesController = new EmployeesController();
        private Employee selectedEmployee;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            lb_employees.DataSource = employeesController.GetEmployees();
            lb_employees.DisplayMember = "FirstName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_employees.SelectedIndex != -1)
            {
                selectedEmployee = (Employee)lb_employees.SelectedItem;
                txt_employee_biography.Text = selectedEmployee.Biography;
                txt_employee_email.Text = selectedEmployee.Email;
                txt_employee_firstname.Text = selectedEmployee.FirstName;
                txt_employee_lastname.Text = selectedEmployee.LastName;
                txt_employee_password.Text = "";
                txt_employee_phoneno.Text = selectedEmployee.PhoneNo;
                num_employee_exp.Value = selectedEmployee.Experience;

                if (selectedEmployee.RoleId == 2)
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
            int role = 0;
            if (cbb_employee_roles.SelectedIndex == 0)
            {
                role = 2;
            }
            else
            {
                role = 3;
            }
            if (string.IsNullOrWhiteSpace(txt_employee_password.Text))
            {
                txt_employee_password.Text = null;
            }
            Employee employee = new Employee(selectedEmployee.EmployeeId, txt_employee_firstname.Text, txt_employee_lastname.Text, txt_employee_email.Text, txt_employee_phoneno.Text, (int)num_employee_exp.Value, malefemale, txt_employee_biography.Text, role);
            employee.Password = txt_employee_password.Text;
            employeesController.EditEmployee(employee);
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
            lb_employees.SelectedIndex = -1;
            lb_employees.DataSource = null;
            lb_employees.DataSource = employeesController.GetEmployees();
            lb_employees.DisplayMember = "FirstName";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            employeesController.DeleteEmployee(selectedEmployee.EmployeeId);
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

        private void btn_backtomain_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}