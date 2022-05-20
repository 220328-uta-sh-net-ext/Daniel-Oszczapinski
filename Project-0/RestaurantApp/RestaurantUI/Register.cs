using RestaurantBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    internal class Register : IRegisterUser
    {
        public string getRegistered(bool repeat)
        {
            Login login = new();
            ChooseRegister chooseRegister = new ChooseRegister();
            Console.WriteLine("Hello, Welcome to the Restaurant Application");
            ChooseAdmin chooseAdmin = new ChooseAdmin();


        Selectionmain:
            Console.WriteLine("Choose if you are an Admin or User.");

            chooseAdmin.Display();
            Choice.FirstChoice = chooseAdmin.UserChoice();
            if(Choice.FirstChoice=="MainMenu")
            {
                goto Selectionmain;
            }
            else if(Choice.FirstChoice == "User")
            {
            userSeclection:
                chooseRegister.Display();
                Choice.SecondChoice= chooseRegister.UserChoice();
                if (Choice.SecondChoice == "Registered User")
                {
                    var result = login.UserInput(Choice.FirstChoice);
                    return result;
                }
                else if(Choice.SecondChoice == "New User")
                {
                    while (repeat)
                    {
                        var menu = new AddUser();
                        menu.Display();
                        string choice = menu.UserChoice();
                        if (choice == "Create User")
                        {
                        menu = new AddUser();
                        }
                        else if (choice == "Login")
                        {
                            var result = login.UserInput(Choice.FirstChoice);
                            return result;
                        }
                        //var result = addUser.UserChoice(); //Might need to add something here
                        
                       
                        
                        //Choice.SecondChoice = "Registered User";
                        
                    }
                    return "Failed";
                }
                else
                {
                    Console.WriteLine("Wrong option selected");
                    goto userSeclection;
                }

            }
            else if (Choice.FirstChoice == "Admin")
            {
                var result =login.UserInput(Choice.FirstChoice);
                return result;
            }
            return "Failed";
        }
    }
}
