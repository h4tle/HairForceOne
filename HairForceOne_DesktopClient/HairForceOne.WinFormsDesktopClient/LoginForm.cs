﻿using HairForceOne.WinFormsDesktopClient.Controller;
using System;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
{
    // ændring af navne
    // regex ??
    public partial class LoginForm : Form
    {
        private LoginController loginController = new LoginController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool LoggedIn = loginController.Login(txt_email.Text, txt_password.Text);
            if (LoggedIn)
            {
                this.Hide();
                var main = new MainForm();
                main.Owner = this;
                main.Show();
                txt_password.Clear();
                txt_email.Clear();
            }
            else
            {
                lbl_header.Text = "Prøv igen";
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
        }
    }
}