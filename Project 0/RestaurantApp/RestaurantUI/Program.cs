using RestaurantUI;
using RestaurantBL;
bool repeat = true;
IMenu menu = new MainMenu();
OperationsBL BLInner = new OperationsBL();

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
            Console.WriteLine("--------------Retreiving all Restaurant Information---------------");
            BLInner.GetAllRestaurants();
            break;
        case "Create Restaurant":
            //call RestaurantLogin method
            menu = new AddRestaurantMenu();
            break;
        case "Create User":
            //call RestaurantLogin method
            menu = new AddUsercs();
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
}
