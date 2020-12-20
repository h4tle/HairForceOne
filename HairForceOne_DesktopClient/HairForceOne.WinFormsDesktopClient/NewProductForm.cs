using HairForceOne.WinFormsDesktopClient.Controller;
using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Linq;
using System.Windows.Forms;

// ændring af navne
// tjek om eneable på create knap virker
namespace HairForceOne.WinFormsDesktopClient
{
    internal partial class NewProductForm : Form
    {
        private ProductsController productsController;

        public NewProductForm(ProductsController productsController)
        {
            this.productsController = productsController;
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
            Product p = new Product(0, txt_brand.Text, txt_title.Text, txt_description.Text, decimal.Parse(txt_purchaseprice.Text), decimal.Parse(txt_retailprice.Text), null, malefemale);
            productsController.CreateNewProduct(p);
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

        private void NewProductForm_Load(object sender, EventArgs e)
        {
        }
    }
}