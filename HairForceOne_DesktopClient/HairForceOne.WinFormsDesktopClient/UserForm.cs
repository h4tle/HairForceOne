﻿using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Windows.Forms;

// ændring af navne
// vis antal bookings ud fra kunde
namespace HairForceOne.WinFormsDesktopClient
{
    public partial class UserForm : Form
    {
        private UsersController usersController = new UsersController();
        private User selectedUser;

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
            usersController.DeleteUser(selectedUser.UserId);
        }

        private void btn_backtomain_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}