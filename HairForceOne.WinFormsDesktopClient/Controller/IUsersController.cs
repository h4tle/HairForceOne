using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Collections.Generic;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal interface IUsersController
    {
        List<User> GetUsers();

        NotImplementedException CreateNewUser(User user);

        NotImplementedException EditUser(User user);

        NotImplementedException DeleteUser(int id);
    }
}