﻿using System;
using static System.Console;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to my application!");

            // Ask for user information
            Person user = new Person();

            Write("What is your first name: ");
            user.FirstName = ReadLine();

            Write("What is your last name: ");
            user.LasName = ReadLine();

            // Checks to be sure the first and last names are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                WriteLine("You did not give us a valid first name!");
                ReadLine();
                return;
            }

            if(string.IsNullOrWhiteSpace(user.LasName))
            {
                WriteLine("You did not give us a valid last name!");
                ReadLine();
                return;
            }

            // Create a username for the person
            WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LasName}");

            ReadLine();

        }
    }
}
