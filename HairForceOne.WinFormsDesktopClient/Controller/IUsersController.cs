using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    interface IUsersController
    {
        List<User> GetUsers();
        NotImplementedException CreateNewUser(User user);
        NotImplementedException EditUser(User user);
        NotImplementedException DeleteUser(int id);
    }
}
