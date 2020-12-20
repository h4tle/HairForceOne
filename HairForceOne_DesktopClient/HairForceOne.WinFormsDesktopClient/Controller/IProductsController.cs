using HairForceOne.WinFormsDesktopClient.Model;
using System.Collections.Generic;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    public interface IProductsController
    {
        List<Product> GetAllProducts();

        Service GetProduct(int id);

        bool CreateNewProduct(Product product);

        bool EditProduct(Product product);

        bool DeleteProduct(int id);
    }
}