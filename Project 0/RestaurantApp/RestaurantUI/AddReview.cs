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
    internal class AddReview : IMenu
    {
        private static Review NewReview = new Review();
       
        private IRepository _repository = new SqlRepository();
        public void Display()
        {
            Console.WriteLine("Enter Review Information");
            Console.WriteLine("<5> Restaurant Name - " + NewReview.Name);
            Console.WriteLine("<4> UserName - " + NewReview.UserName);
            Console.WriteLine("<3> Rating - " + NewReview.Rating);
            Console.WriteLine("<2> Note - " + NewReview.Note);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }
        public string UserChoice()
        {      
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    _repository.AddReview(NewReview);
                    Console.WriteLine("----New Restaurant Added----");
                    return "MainMenu";
                case "2":
                    Console.Write("Please write a review: ");
                    NewReview.Note = Convert.ToString(Console.ReadLine());
                    return "Create Review";
                case "3":
                    Console.Write("Please enter a rating: ");
                    NewReview.Rating = Convert.ToInt32(Console.ReadLine());
                    return "Create Review";
                case "4":
                   Console.Write("Please enter a user name: ");
                    NewReview.UserName = Convert.ToString(Console.ReadLine());
                    return "Create Review";
                case "5":
                    Console.Write("Please enter a restaurant name: ");
                    NewReview.Name = Convert.ToString(Console.ReadLine());
                    return "Create Review";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddUser";
            }
        }
    }
}
