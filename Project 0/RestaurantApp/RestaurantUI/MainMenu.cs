using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    public class MainMenu : IMenu
    {


        public void Display()
        {
            Console.WriteLine("Welcome to this Restuarant Application.");
            Console.WriteLine("Please choose an option.");
            Console.WriteLine("Press <1> Create Restaurant");
            Console.WriteLine("Press <2> Create User");
            Console.WriteLine("Press <3> Create Review");
            Console.WriteLine("Press <4> Filter Search");
            Console.WriteLine("Press <5> Display Restaurant");
            Console.WriteLine("Press <6> Display User");
            Console.WriteLine("Press <7> Display Review");
            Console.WriteLine("Press <0> Exit");
            
            
            
            
        }
        /// <summary>
        /// Goes to the correct menu
        /// </summary>
        /// <returns></returns>
        public string UserChoice()
        {
            string otherinpute = Console.ReadLine();
            switch (otherinpute)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "Create Restaurant";
                case "2":
                    return "Create User";
                case "3":
                    return "Create Review";
                case "4":
                    return "Filtered Search";
                case "5":
                    return "Display Restaurant";
                case "6":
                    return "Display User";
                case "7":
                    return "Display Review";
                default:
                    Console.WriteLine("View does not exist");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";

            }
        }
    }
}

