# Delegates, anonymous methods, Lambda expressions, What is it, why use it and Show by code

## Delegates

![](https://www.tutorialsteacher.com/Content/images/csharp/delegate-mapping.png)

### What are Delegates?

- A delegate is a type that represents references to methods with a particular parameter list and return type. You are also able to define variables of delegates.
- Delegates are type-safe, object oriented and secure because we are referencing methods which prevents incorrect coding from happening.

Delegate declaration  code:

```text
public delegate int PerformCalculation(int x, int y);
```

### Why are Delegates used?

- Allows programmers to pass methods as arguments to other methods. Delegates make implementing events and call-back methods easier than other possible solutions.
- Delegates provide flexibility to your code because  easily add the new code into existing classes or change the method call.
- Delegates can also be more general since the comparison code is separate  from the library.

### Func Delegate, What are they?

- [Func] is a generic delegate that is part of the System namespace.
This delegate encapsulates a method that has no parameter or more parameters and returns a value of the type specified.

![](https://www.tutorialsteacher.com/Content/images/csharp/func-delegate.png)

### Action Delegate, What are they?

- An [Action] is a generic delegate and is similar to the Func Delegate but it does not ruturn a value.
- The Action delegates can be used with methods that have a void return type.
- 

### Code Example of Delegates

This code does not apply delegates:

```text
protected void Page_Load(object sender, EventArgs e)  
{  
  
    if (!IsPostBack)  
    {  
        GetData("Mahesh");  
    }  
}  
public void GetData(string Name)  
{  
    lblName.Text = Name;  
}  
```

This code applies delegates:
Allowing us to call another method as parameters and allowing for better speraration of concerns.

```text
public delegate void MyDelegare(string var);  
protected void Page_Load(object sender, EventArgs e)  
  
{  
    if (!IsPostBack)  
    {  
        MyDelegare objMyDelegare = new MyDelegare(GetData);  
        objMyDelegare("Mahesh");  
    }  
}  
public void GetData(string Name)  
{  
    lblName.Text = Name;  
}  
```

## References/Links

-Delegate Links: [Microsoft-Delegates](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/), [TutorialsTeacher](https://www.tutorialsteacher.com/csharp/csharp-delegates), [C-Sharpcorner](https://www.c-sharpcorner.com/UploadFile/8911c4/simple-delegates-with-examples-in-C-Sharp/), [Microsoft-Func](https://docs.microsoft.com/en-us/dotnet/api/system.func-2?view=net-6.0), [Microsoft-Action](https://docs.microsoft.com/en-us/dotnet/api/system.action?view=net-6.0)