using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    enum Authority
    {
        Hire, Fire, Delegate
    }
    public class Employee
    {
        //what a class can consist of are: Members -> variables, constants, methods, events, contructors, ...)

        //inisitallize a variable -> state of the object
        public string firstName = "joe", lastName = "Rooe", id = "101";
        public const string planet = "Earth";

        //Method --> Behavior
        public void DoTask(string firstName, string lastName, string id, float hours)
        {
            //firstName = firstName; // Warning but not error these are nam ambiguity need to change the method variable
            this.firstName = firstName;
            //lastName = lastName;
            this.lastName = lastName;
            //id = id;
            this.id = id;

            Console.WriteLine($"{firstName} {lastName} writes program in c# {hours} hours in a day and has the id {id}");
        }
        //Examples of Types
        /*struct MyStruct
        {

        }
        enum MyEnum
        {

        }
        interface MyInterface
        {

        }*/
        //delegate void MyDelegate(MyEnum n);

        //Salary Components of Employee
        decimal payRate, takes, healthCare, bonus, overtime, reinbursements;

        public decimal CalculateSalary() 
        {
            return payRate;
        }



        class Manager : Employee
        {
            public Authority authority;
            public void GetDetails()
            {
                //firstName
            }

        }

    }
}
