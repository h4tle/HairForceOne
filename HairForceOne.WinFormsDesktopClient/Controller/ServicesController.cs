using HairForceOne.WinFormsDesktopClient.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    class ServicesController : IServicesController
    {
        private RestClient client;
        public ServicesController(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }
        public ServicesController()
        {
            client = new RestClient(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
        }
        public void Create(Service Service)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Service GetService(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetServices()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Service Service)
        {
            throw new NotImplementedException();
        }
    }
}
