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
    public partial class ProductForm : Form
    {
        ProductsController productsController = new ProductsController();
        Product selectedProduct;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = productsController.GetProducts();
            listBox1.DisplayMember = "Title";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                selectedProduct = (Product) listBox1.SelectedItem;
                txt_brand.Text = selectedProduct.Brand;
                txt_title.Text = selectedProduct.Title;
                txt_description.Text = selectedProduct.Description;
                txt_weight.Text = selectedProduct.Weight;
                txt_price.Text = selectedProduct.RetailPrice.ToString();
                if (selectedProduct.Gender == "Female")
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
            Product p = new Product(selectedProduct.ProductId, txt_brand.Text, txt_title.Text, txt_description.Text, txt_weight.Text, selectedProduct.PurchasePrice, decimal.Parse(txt_price.Text), selectedProduct.Color, malefemale);
            productsController.Update(p);
            ReloadForm();
        }

        private void ReloadForm()
        {
            txt_brand.Clear();
            txt_title.Clear();
            txt_description.Clear();
            txt_weight.Clear();
            txt_price.Clear();
            rb_female.Checked = false;
            rb_male.Checked = false;
            listBox1.SelectedIndex = -1;
            listBox1.DataSource = null;
            listBox1.DataSource = productsController.GetProducts();
            listBox1.DisplayMember = "Title";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            productsController.Delete(selectedProduct.ProductId);
            ReloadForm();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Form f = new NewProductForm(productsController);
            f.FormClosed += F2_FormClosed;
            f.ShowDialog();
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadForm();
        }
    }
}