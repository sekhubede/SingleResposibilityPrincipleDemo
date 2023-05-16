using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    internal class AccountGenerator
    {
        public static void CeateAccount(Person user)
        {
            // Create a username for the person
            WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LasName}");
        }
    }
}
