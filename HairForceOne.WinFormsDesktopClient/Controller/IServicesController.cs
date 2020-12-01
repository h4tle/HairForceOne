using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    public interface IServicesController
    {
        List<Service> GetServices();
        Service GetService(int id);
        void Create(Service Service);
        void Update(int id, Service Service);
        void Delete(int id);
    }
}
