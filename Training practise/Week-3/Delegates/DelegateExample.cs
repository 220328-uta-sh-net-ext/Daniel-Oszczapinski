using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;

namespace Delegates
{
    public class DelegateExample
    {
          static void Display(string S) {  
            Console.WriteLine("My Name is :" + S);  
        }  
        delegate void X(string a);  
        static void Main(string[] args) {  
            X objD = new X(Display);  
            objD("Rathrola Prem Kumar");  
            Console.Read();  
        }  

    


    

    }
}
