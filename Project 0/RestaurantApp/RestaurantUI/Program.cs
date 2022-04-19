using RestaurantUI;
bool repeat = true;
IMenu menu = new MainMenu();

/*while (repeat)
{
    menu.Display();
    string ans = menu.Login();

    switch (ans)
    {
        case "Login":
            //call RestaurantLogin method
            Console.WriteLine("RestaurantLogin() Method implementation is in progress....");
            break;
        case "Create":
            //call RestaurantAdd method
            Console.WriteLine("RestuarantAdd() Method implementaion is in progress....");
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
  
}*/
while (repeat)
{
    menu.Display();
    string choice = menu.UserChoice();
    switch (choice)
    {
        case "Login":
            //call RestaurantLogin method
            Console.WriteLine("RestaurantLogin() Method implementation is in progress\n");
            break;
        case "Display Restaurant":
            //call RestaurantLogin method
            Console.WriteLine("RestaurantDisplay() Method implementation is in progress\n");
            break;
        case "Create Restaurant":
            //call RestaurantLogin method
            Console.WriteLine("RestaurantCreate() Method implementation is in progress\n");
            break;
        case "Create User":
            //call RestaurantLogin method
            Console.WriteLine("RestaurantUser() Method implementation is in progress\n");
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}
