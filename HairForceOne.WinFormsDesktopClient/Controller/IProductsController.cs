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
        List<Product> GetProducts();
        Service GetProduct(int id);
        NotImplementedException Create(Product product);
        NotImplementedException Update(Product product);
        NotImplementedException Delete(int id);
    }
}
