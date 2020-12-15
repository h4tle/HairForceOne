using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal interface ILoginsControlller
    {
         bool Login(string Email, string Password);
    }
}
