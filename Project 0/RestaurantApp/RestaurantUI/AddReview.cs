using RestaurantDL;
using RestaurantInfo;
using RestaurantBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    /// <summary>
    /// Adding Review Menu
    /// </summary>
    internal class AddReview : IMenu
    {
        private static Review NewReview = new Review();
       
       // private IRepository _repository = new SqlRepository();
        public void Display()
        {
            Console.WriteLine("Enter Review Information");
            
           
            Console.WriteLine("<1> Rating - " + NewReview.Rating);
            Console.WriteLine("<2> Note - " + NewReview.Note);
            Console.WriteLine("<3> Save");
            Console.WriteLine("<0> Go Back");
        }
        public string UserChoice()
        {      
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    Log.Information("Return to Main Menu");
                    return "MainMenu";
                case "1":
                    Log.Information("Adding Rating - " + NewReview.Rating);
                    Console.Write("Please enter a rating: ");
                    NewReview.Rating = Convert.ToInt32(Console.ReadLine());
                    return "Create Review";
                case "2":
                    Log.Information("Adding Note - " + NewReview.Note);
                    Console.Write("Please write a review: ");
                    NewReview.Note = Convert.ToString(Console.ReadLine());
                    return "Create Review";
                case "3":
                    Log.Information("Saving Information");
                    //_repository.AddReview(NewReview);
                    Console.WriteLine("----New Review Added----");
                    return "MainMenu";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddUser";
            }
        }
    }
}
