using HairForceOne.WinFormsDesktopClient.Model;
using System.Collections.Generic;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    public interface IServicesController
    {
        List<Service> GetAllServices();

        Service GetService(int id);

        bool CreateNewService(Service Service);

        bool EditService(Service Service);

        bool DeleteService(int id);
    }
}