using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
