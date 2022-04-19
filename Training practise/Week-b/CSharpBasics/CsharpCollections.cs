//For Non-generics 
using System.Collections;
//for generics
using System.Collections.Generic;
namespace CSharpBasics
{
    public class CsharpCollections
    {
        public static void NonGenerics()
        {
            /*ArrayList employees=new ArrayList(); // creates an arraylist
            employees.Add("Roger"); // added an item as string but it is stored as object. 
            employees.Add("Jay");
            employees.Add(123);*/ //will print out becuase of boxing

            var employees = new ArrayList(){"Larry", "Joe", 123}; //another notation known as anonymous object notation for creating an array.

            Console.WriteLine(employees.Count); // counts the amount of elements 
            //Console.WriteLine(employees[1]); // Prints out the name you choose.
            /*foreach (var item in employees)   //Prints employee name
            {       
                Console.WriteLine(item);
            }*/

            employees.Remove("Jay"); // removes element from array
            Console.WriteLine(employees.Count);
        }

        public static void GenericList()
        {
            
            List<string> employees = new List<string>();
            employees.Add("Lake");
            employees.Add("Sour");
            employees.Add("Main");
            employees.Insert(2,"Rob");

            employees.Sort();
            employees.Reverse();
            //employees.Remove("Sour");
            employees.RemoveAt(2);
            //Console.WriteLine(employees[1]);
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }

        public static void GenericStack()
        {
            Stack<string> calls = new Stack<string>();
            
            calls.Push("234");
            calls.Push("445");
            calls.Push("667");
            calls.Push("889");

            calls.Pop();
            
            Console.WriteLine($"Top of the stack {calls.Peek()}");
                foreach (var c in calls)
                {
                Console.WriteLine(c);
                }
            
        }
    
        public static void GenericDictionary()
        {
            Dictionary<int,string> employees= new Dictionary<int, string>();
            employees.Add(101, "Sara");
            employees.Add(102, "Joe");
            employees.Add(103, "Loe");
            employees.Add(104, "Barbra");

            employees[102] = "Bob"; //replaces the string in the element chosen.
            foreach (var num in employees.Keys)
            {
                Console.WriteLine($"{num} - {employees[num]}");
            }
        }
    

        public static void GenericLinkedList()
        {
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddLast("Matt");
            mylist.AddLast("Greg");
            mylist.AddLast("Frank");
            mylist.AddFirst("Larry");
           // Console.WriteLine($"First - {mylist.First.Value}");
           // Console.WriteLine($"Last - {mylist.Last.Value}");
            //mylist.AddBefore(mylist.First,"Hi");
            foreach (var str in mylist)
            {
                Console.WriteLine(str);
            }
            
        }

        public static void GenericQueues()
        {
            Queue<string> mylist = new Queue<string>();
            mylist.Enqueue("Matt");
            mylist.Enqueue("Greg");
            mylist.Enqueue("Frank");
            mylist.Enqueue("Larry");

            foreach (var str in mylist)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine($"Count is ");
        }
    }
}