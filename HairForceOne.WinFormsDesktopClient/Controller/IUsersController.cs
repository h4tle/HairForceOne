using HairForceOne.WinFormsDesktopClient.Model;
using System.Collections.Generic;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal interface IUsersController
    {
        List<User> GetUsers();

        bool CreateNewUser(User user);

        bool EditUser(User user);

        bool DeleteUser(int id);
    }
}