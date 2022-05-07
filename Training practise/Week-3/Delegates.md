# Delegates, anonymous methods, Lambda expressions, What is it, why use it and Show by code

## Delegates

![](https://www.tutorialsteacher.com/Content/images/csharp/delegate-mapping.png)

### What are Delegates?

- A delegate is a type that represents references to methods with a particular parameter list and return type. You also able to define variables of delegates. 

### Why are Delegates used?

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

## Anonymous methods

### Anonymous methods Definition

### What are Anonymous Methods?

### Why use Anonymous Methods?

### Code Example of Anonymous methods

## Lambda Expressions

### Lambda Expressions Definition

### What are Lambda Expressions?

### Why use Lambda Expressions?

### Code Example of Lambda Expressions

## References/Links

-Delegate Links: [Microsoft](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/), [TutorialsTeacher](https://www.tutorialsteacher.com/csharp/csharp-delegates), [C-Sharpcorner](https://www.c-sharpcorner.com/UploadFile/8911c4/simple-delegates-with-examples-in-C-Sharp/),