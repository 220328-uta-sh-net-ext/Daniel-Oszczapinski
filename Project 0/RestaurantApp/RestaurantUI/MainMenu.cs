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
            if (RestaurantBL.Choice.FirstChoice == "Admin")
            {
                Console.WriteLine("Welcome to this Restuarant Application.");
                Console.WriteLine("Please choose an option.");
                Console.WriteLine("Press <1> Create Restaurant");
                Console.WriteLine("Press <2> Display Restaurant");
                Console.WriteLine("Press <3> Display User");
                Console.WriteLine("Press <4> Display Review");
                Console.WriteLine("Press <0> Exit");
            }
            else if (RestaurantBL.Choice.SecondChoice == "Registered User" && RestaurantBL.Choice.FirstChoice == "User")
            {
                Console.WriteLine("Press <1> Create Review");
                Console.WriteLine("Press <2> Filter Search");
                Console.WriteLine("Press <3> Display Restaurant");
                Console.WriteLine("Press <4> Display Review");
                Console.WriteLine("Press <0> Exit");
            }
            
            
        }
        /// <summary>
        /// Goes to the correct menu
        /// </summary>
        /// <returns></returns>
        public string UserChoice()
        {
            string otherinput = Console.ReadLine();
            if (RestaurantBL.Choice.FirstChoice == "Admin" || RestaurantBL.Choice.FirstChoice == "admin")
            {
                switch (otherinput)
                {
                    case "0":
                        return "Exit";
                    case "1":
                        return "Create Restaurant";
                    case "2":
                        return "Display Restaurant";
                    case "3":
                        return "Display User";
                    case "4":
                        return "Display Review";
                    default:
                        Console.WriteLine("View does not exist");
                        Console.WriteLine("Please press <enter> to continue");
                        Console.ReadLine();
                        return "MainMenu";
                }
            }
            else {
                switch(otherinput)
                {
                   case "0":
                        return "Exit";
                    case "3":
                        return "Create Review";
                    case "4":
                        return "Filtered Search";
                    case "5":
                        return "Display Restaurant";
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
}

