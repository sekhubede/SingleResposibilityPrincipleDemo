using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    internal class PersonDataCapture
    {
        // Capture and return person information
        public static Person Capture()
        {
            // Ask for user information
            Person output = new Person();

            Write("What is your first name: ");
            output.FirstName = ReadLine();

            Write("What is your last name: ");
            output.LasName = ReadLine();

            return output;
        }
    }
}
