global using Serilog;
using RestaurantUI;
using RestaurantBL;
using RestaurantDL;

bool repeat = true;
IMenu menu = new MainMenu();
Register register = new Register();

//readonly string connectionString;
//IRepository repository = new SqlRepository(connectionString);
OperationsBL BLInner = new OperationsBL();
/// <summary>
/// Log the Users activity 
/// </summary>
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("C:/Revature/dotnet-training-220328/Daniel-Oszczapinski/Project 0/RestaurantApp/RestaurantUI/Logging.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the ;ogs in this file
    .CreateLogger();

/// <summary>
/// Switch case that give the option for the user
/// </summary>
var result = register.getRegistered(repeat);
if (result == "Login Success")
{
    while (repeat)
    {
        menu.Display();
        string choice = menu.UserChoice();
        switch (choice)
        {
            case "Filtered Search":
                Log.Information("Display All Review Information");
                Console.WriteLine("--------------Retreiving Information By Filter---------------");
                menu = new FilteredMenu();
                break;
            case "Display Review":
                Log.Information("Display All Review Information");
                Console.WriteLine("--------------Retreiving all Review Information---------------");
                BLInner.GetAllReviews();
                break;
            case "Display User":
                Log.Information("Display All User Information");
                Console.WriteLine("--------------Retreiving all User Information---------------");
                BLInner.GetUser();
                break;
            case "Create Review":
                Log.Information("Creating a Review");
                //call RestaurantLogin method
                menu = new AddReview();
                break;
            case "Display Restaurant":
                Log.Information("Display All Restaurant Information");
                //call RestaurantLogin method
                Console.WriteLine("--------------Retreiving all Restaurant Information---------------");
                BLInner.GetAllRestaurants();
                break;
            case "Create Restaurant":
                Log.Information("Creating Restaurant");
                //call RestaurantLogin method
                menu = new AddRestaurantMenu();
                break;
            case "Create User":
                Log.Information("Creating User");
                //call RestaurantLogin method
                menu = new AddUser();
                break;
            case "MainMenu":
                Log.Information("Going back to Main Menu");
                menu = new MainMenu();
                break;
            case "Exit":
                Log.Information("Leaving Application");
                repeat = false;
                break;
            default:
                Console.WriteLine("View does not exist");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                break;
        }
    }
}
else
{
    Console.WriteLine("Login Failed");
}