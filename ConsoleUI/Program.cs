using System;
using static System.Console;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Create a username for the person
            WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LasName}");

            StandardMessages.EndApplication();

        }
    }
}
