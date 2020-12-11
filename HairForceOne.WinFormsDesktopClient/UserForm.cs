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
    public partial class UserForm : Form
    {
        UsersController usersController = new UsersController();
        User selectedUser;
        public UserForm()
        {
            InitializeComponent();

        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            lb_users.DataSource = usersController.GetUsers();
            lb_users.DisplayMember = "FirstName";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_users.SelectedIndex != -1)
            {
                selectedUser = (User)lb_users.SelectedItem;
                lbl_user.Text = selectedUser.FirstName;
                lbl_users_mail.Text = selectedUser.Email;
                lbl_userphoneno.Text = selectedUser.PhoneNo;


            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            usersController.Delete(selectedUser.UserId);
        }
    }
}
