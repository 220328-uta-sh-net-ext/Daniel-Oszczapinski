using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    internal class ChooseRegister : IMenu
    {
        public void Display()
        {
            Console.WriteLine("\nAre you a New user or a Registered user?");
            Console.WriteLine("Press <1> New User");
            Console.WriteLine("Press <2> Registered User");
            Console.WriteLine("Press <0> Exit");
        }

        public string UserChoice()
        {
            string mainChoice = Console.ReadLine();
            int choice;
            if (int.TryParse(mainChoice, out choice) != true)
            {
                Console.Clear();
                return "mainMenu";
            }


            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    return "";

                case 1:
                    return "New User";

                case 2:
                    return "Registered User";

                default:
                    Console.WriteLine("Please select proper option!!");
                    Console.Clear();
                    return "mainMenu";
            }
        }
    }
}
