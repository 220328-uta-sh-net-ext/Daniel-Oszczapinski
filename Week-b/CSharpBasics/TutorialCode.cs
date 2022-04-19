//All the challenge codes used during tutorial for reference.
namespace CSharpBasics
{
    public class TutorialCode
    {
        public static void Basic()
        {
            //Writing out basic code
            Console.WriteLine("This is the first line.");

            Console.Write("This is ");
            Console.Write("the second ");
            Console.Write("line.");
        }


        public static void StoreVariables()
        {
            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");
        }


        public static void WriteMessage()
        {
            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
        }


        public static void TempCode()
        {
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");
        }


        public static void LargestValue()
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);
        }


        public static void BusinessRules()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }
        }


        public static void PrintBArrays()
        {
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string orderID in orderIDs)
            {
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }
        }


        public static void ReverseAndCount()
        {
            /*
             This code reverses a message, counts the number of times 
            a particular character appears, then prints the results
                 to the console window.
                */

            string originalMessage = "The quick brown fox jumps over the lazy dog.";

            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);

            int letterCount = 0;

            foreach (char letter in message)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }

            string newMessage = new String(message);

            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");
        }


        public static void CoinFlip()
        {
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");
        }


        public static void AdminCase()
        {
            string permission = "Admin|Manager";
            int level = 53;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }


        public static void RewriteCode()
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;

            foreach (int number in numbers)
            {
                total += number;
                if (number == 42) found = true;
            }

            if (found) Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");
        }


        public static void IfelseSplit()
        {
            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            if (product[0] == "01")
            {
                type = "Sweat shirt";
            }
            else if (product[0] == "02")
            {
                type = "T-Shirt";
            }
            else if (product[0] == "03")
            {
                type = "Sweat pants";
            }
            else
            {
                type = "Other";
            }

            if (product[1] == "BL")
            {
                color = "Black";
            }
            else if (product[1] == "MN")
            {
                color = "Maroon";
            }
            else
            {
                color = "White";
            }

            if (product[2] == "S")
            {
                size = "Small";
            }
            else if (product[2] == "M")
            {
                size = "Medium";
            }
            else if (product[2] == "L")
            {
                size = "Large";
            }
            else
            {
                size = "One Size Fits All";
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        }


        public static void SwitchCaseSplit()
        {
            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        }


        public static void FizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine($"{i} - FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i} - Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine($"{i} - Buzz");
                else
                    Console.WriteLine($"{i}");
            }
        }


        public static void RoleplayingGame()
        {
            int hero = 10;
            int monster = 10;

            Random dice = new Random();

            do
            {
                int roll = dice.Next(1, 11);
                monster -= roll;
                Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

                if (monster <= 0) continue;

                roll = dice.Next(1, 11);
                hero -= roll;
                Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
        }


        public static void CheckVarandAdd()
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string message = "";

            foreach (var value in values)
            {
                decimal number;
                if (decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");
        }


        public static void NarrowOrWidenNum()
        {
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            int result1 = Convert.ToInt32((decimal)value1 / value2);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }


        public static void SplitandReverse()
        {
            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);
        }

        public static void SplitAndFind()
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] items = orderStream.Split(',');

            foreach (var item in items)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }
        }


        public static void FormattingCorrectly()
        {
            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);
        }


        public static void IndexAndReplace()
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            const string spanTag = "<span>";

            // Extract the quantity
            int quantityStart = input.IndexOf(spanTag);
            int quantityEnd = input.IndexOf("</span>");
            quantityStart += spanTag.Length;
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            output = input.Replace("&trade;", "&reg;");

            // Remove the opening <div> tag
            int divStart = input.IndexOf("<div");
            int divEnd = input.IndexOf(">");
            int divLength = divEnd - divStart;
            divLength += 1;
            output = output.Remove(divStart, divLength);

            // Remove the closing <div> tag
            int divCloseStart = output.IndexOf("</div");
            int divCloseEnd = output.IndexOf(">", divCloseStart);
            int divCloseLength = divCloseEnd - divCloseStart;
            divCloseLength += 1;
            output = output.Remove(divCloseStart, divCloseLength);

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");
        }


    }
}