using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    interface IEmployeesController
    {
        List<Employee> GetEmployees();
        Employee GetProduct(int id);
        NotImplementedException Create(Employee employee);
        NotImplementedException Update(Employee employee);
        NotImplementedException Delete(int id);
    }
}
