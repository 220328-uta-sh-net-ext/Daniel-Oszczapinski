using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    internal class ChooseAdmin : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Press <1> User");
            Console.WriteLine("Press <2> Admin");
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
                    return "User";

                case 2:
                    return "Admin";

                default:
                    Console.WriteLine("Please select proper option!!");
                    Console.Clear();
                    return "mainMenu";
            }
           }
    }
}
