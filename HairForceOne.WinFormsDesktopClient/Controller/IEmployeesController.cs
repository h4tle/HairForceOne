using HairForceOne.WinFormsDesktopClient.Model;
using System.Collections.Generic;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal interface IEmployeesController
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(int id);

        bool CreateNewEmployee(Employee employee);

        bool EditEmployee(Employee employee);

        bool DeleteEmployee(int id);
    }
}