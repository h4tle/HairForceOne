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
        List<Service> GetAllServices();
        Service GetService(int id);
        NotImplementedException CreateNewService(Service Service);
        NotImplementedException EditService(Service Service);
        NotImplementedException DeleteService(int id);
    }
}
