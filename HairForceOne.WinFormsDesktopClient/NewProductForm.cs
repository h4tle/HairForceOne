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
    internal partial class NewProductForm : Form
    {
        ProductsController ProductsController;
        public NewProductForm(ProductsController productsController)
        {
            this.ProductsController = productsController;
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
            Product p = new Product(0, txt_brand.Text, txt_title.Text, txt_description.Text, txt_weight.Text, decimal.Parse(txt_purchaseprice.Text), decimal.Parse(txt_retailprice.Text), null, malefemale);
            ProductsController.Create(p);
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
