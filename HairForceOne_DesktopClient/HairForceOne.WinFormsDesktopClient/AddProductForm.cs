﻿using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Windows.Forms;

namespace HairForceOne.WinFormsDesktopClient
{
    public partial class AddProductForm : Form
    {
        private ProductsController productsController = new ProductsController();

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            Lb_products.DataSource = productsController.GetAllProducts();
            Lb_products.DisplayMember = "Title";
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            var parent = (BookingForm)this.Owner;
            parent.addNewProduct((Product)Lb_products.SelectedItem);
            this.Close();
        }
    }
}