// comments - Single line, comments are not processed by compiler and CLR
/*
multi 
line 
comments
*/
/*
Predefined namespace 
using System; <- was used in older version of .Net, .Net 6 does not require
*/

namespace HelloWorld {
    // types (Class, Enum, Struct, Delegate, Interface)
    public class Program{
        // Main enter point, only 1 main per project 
        public static void Main(){
        // Console is a class and WriteLine is a method within the class.
        Console.WriteLine("Hello, World!");
        Console.Write("Please enter your name: ");
        // var is a data type that adjusts the type based on the input.
        var name=Console.ReadLine(); // This will allow users to take input in string format
        var currentDate = DateTime.Now;
        // $ allows you to add the variables to the method in an easier fashion.
        // Environment.NewLine or \n adds a line
        Console.WriteLine($"{Environment.NewLine}Current Date: {currentDate:d} and Current time {currentDate:t} \nHello {name}.");
        }
    }
}