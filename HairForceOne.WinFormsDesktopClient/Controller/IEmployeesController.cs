using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Collections.Generic;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal interface IEmployeesController
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(int id);

        NotImplementedException CreateNewEmployee(Employee employee);

        NotImplementedException EditEmployee(Employee employee);

        NotImplementedException DeleteEmployee(int id);
    }
}