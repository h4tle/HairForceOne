using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Collections.Generic;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    public interface IProductsController
    {
        List<Product> GetAllProducts();

        Service GetProduct(int id);

        NotImplementedException CreateNewProduct(Product product);

        NotImplementedException EditProduct(Product product);

        NotImplementedException DeleteProduct(int id);
    }
}