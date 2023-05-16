using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    internal class StandardMessages
    {
        public static void WelcomeMessage()
        {
            WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
           WriteLine($"You did not give us a valid { fieldName }!");
        }
    }
}
