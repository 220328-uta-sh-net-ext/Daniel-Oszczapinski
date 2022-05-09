# Delegates, What is it, why use it and Show by code

## Delegates

### What are Delegates?

- A delegate is a type that represents references to methods with a particular parameter list and return type. You are also able to define variables of delegates.
- Delegates are type-safe, object oriented and secure because we are referencing methods which prevents incorrect coding from happening.
- Delegates allow you to assign a method to the delegate and the method will be called each time the delegate is called.

Delegate declaration  code:

```text
public delegate int PerformCalculation(int x, int y);
```

### Why are Delegates used?

- Allows programmers to pass methods as arguments to other methods. Delegates make implementing events and call-back methods easier than other possible solutions.
- Delegates provide flexibility to your code because you can easily add the new code into existing classes or change the method call.
- Delegates can also be more general since the comparison code is separate from the library.

### Code Example of Delegates

This code applies delegates:
Allowing us to call another method as parameters and allowing for better separation of concerns.

```text
public delegate void MyDelegare(string var);  
protected void Page_Load(object sender, EventArgs e)  
  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
namespace DelegatesDemo {  
    class Program {  
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
```

## Func Delegate, What are they?

- [Func] is a generic delegate that is part of the System namespace.
This delegate encapsulates a method that has no parameter or more parameters and returns a value of the type specified.
- This allows you to minimize the amount of code required for methods

![](https://www.tutorialsteacher.com/Content/images/csharp/func-delegate.png)

### Code Example of Func

This code uses two parameters and returns a value in Int

```text
class Program
{
    static int Sum(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Func<int,int, int> add = Sum;

        int result = add(10, 10);

        Console.WriteLine(result); 
    }
}
```

## Action Delegate, What are they?

- An [Action] is a generic delegate and is like the Func Delegate but it does not ruturn a value.
- The Action delegates can be used with methods that have a void return type.
- Able to remove the declared delegate.
- Requires more code to implement Action than Func.

### Code Example of Action

You are able to remove the delegate and add an action delegate instead.

```text
public delegate void Print(int val);
```

Code that uses Action delegate and it does not require you to define the parameter:

```text
static void ConsolePrint(int i)
{
    Console.WriteLine(i);
}

static void Main(string[] args)
{
    Action<int> printActionDel = ConsolePrint;
    printActionDel(10);
}
```

### Predicate delegate, What are they?

- [Predicate] is a generic delegate and this method contains a set of criteria and checks if the parameter meets the conditions.
- Predicate can only take one parameter and will return a Boolean value.

Predicate code:

```text
public delegate bool Predicate<in T>(T obj);
```

### Example of Predicate Code

This code defines the delegate named predicate and assigns it to a method named IsUpperCase. This will Return False because the string is lower case:

```text
static bool IsUpperCase(string str)
{
    return str.Equals(str.ToUpper());
}

static void Main(string[] args)
{
    Predicate<string> isUpper = IsUpperCase;

    bool result = isUpper("hello world!!");

    Console.WriteLine(result);
}
```

## Anonymous Method, What are they?

- [Anonymous] methods are methods that do not have a name and invoked directly by delegate keyword.
- When the delegate keyword is used you can remove the parameter list, this allows the anonymous method to convert a delegate type with any list of parameters.
- This associates the method definition to a delegate, when you bind with a callback this anonymous method will be called. Which ensures that this delegate is called at a particular event.
- You cannot use Lambda Expressions unlike other delegates.

### Example of Anonymous Method

```text
public delegate void Print(int value);

static void Main(string[] args)
{
    // Delegate keyword
    Print print = delegate(int val) { 
        Console.WriteLine("Inside Anonymous method. Value: {0}", val); 
    };

    print(100);
}
```

## References/Links

-Delegate Links:

[Microsoft-Delegates](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/),

[C-Sharpcorner](https://www.c-sharpcorner.com/UploadFile/8911c4/simple-delegates-with-examples-in-C-Sharp/)

[Microsoft-Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2?view=net-6.0)

[Microsoft-Action](https://docs.microsoft.com/en-us/dotnet/api/system.action?view=net-6.0)

[Microsoft-Predicate](https://docs.microsoft.com/en-us/dotnet/api/system.predicate-1?view=net-6.0)

[Anonymous](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/delegates-with-named-vs-anonymous-methods)

[TutorialsTeacher](https://www.tutorialsteacher.com/csharp/csharp-delegates)
