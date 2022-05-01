# Qc Quesions on the Advance C#.

1. What are [generics]?

    - [Generics] - means not to be specific to a particular data type.
    - allows you to define generic classes, interfaces, abstract classes, fields, methods, properties and few other things using the "type parameter" and not specifing the data type.
    - By using generics you can get strongly typed code and performance is improved becuase you do not have to do boxing or unboxing.

2. What is [Socialization] and [Deserialization]?
    - [Serialization] - is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database or file.
    - its main purpose is to save the state of an object in order to be able to recreate it when needed.
    - The reversed is called [Deserialization] and it is the process of getting back the serialized object so that it can be loaded into memory.

3. What is [Testing]?

    - We use [unit-testing] to perform tests. [Unit-testing] is to check that you code is working as expected. By breaking down the functionality of your program into descrete testable behaviors that you can test as individual units.
    - Unit testing has the greatest effect on the quality of your code when its an integral part of your software development workflow.

    - A good practice is as soon as you write a function or other block of application code, create unit tests that your code is working with diffrent perameters.

4. What is the [TDD]?

    - [Test-driven-Development] is heavily used in Unit Testing.
    - [Test-driven-Development] is a software development process relying on software requirements being converted to test cases before software is fully developed, and tracking all software development by repeatedly testing the software against all test cases. This is as opposed to software being developed first and test cases created later

    [Flow-of-TDD]
    - Create a test case - What you expect the feature is suppose to do
    - Running the test case will fail the first time - obviously since you haven't created the actual implementation details to make it pass
    - Write code so the new test case will pass
    -Make sure old test cases won't fail because of the new feature (probably the biggest thing as to why we do unit testing so anything new added will also test our old functionalities to make sure everything is working as intended)
    - [refractor]which is to Clean up the code and have proper documentation for other developers

    - [Arrange], [Act], and [Assert] (The 3 good ole As)
    - [Arrange]
        - This is where you initiliaze objects or some values you will need for the test
    - [Act]
        - Invokes the method/function under the test with the arranged objects/values
    - [Assert]
        - Verifies that the action of the method under the tests behaves as expected

5. What is [code-coverage] and why use it?

    - [Code-Coverage] is the percentage given to you on how much lines of your code is actually covered by the unit testing.
    that can be either lines, branches, or methods.
    - This allows us to get a good idea of how much our code has code coverage and where more testing need to be made.
    - We are using [Coverlet] is a cross platform code coverage framework for .NET, with support for line, branch and method coverage.

6. What is [Logging], why use it and what package would we use?

    - The a way to record a series of events depending on what exactly you are trying to capture
        - Diffrent logging levels we can use for diffrent events we want to log
        - [Trace] - which contain sensitive app data and disabled by default
        - [Debug] - For debugging and development.
        - [Information] - which Tracks the general flow of the app
        - [Warning] - For abnormal or unexpected events.
        - [Error] - For errors and exceptions that cannot be handled.
        - [Critical] - For failures that require immediate attention
        - [None] - Specifies that no messages should be written

    - The main purpose is for debugging for potential bugs, since the main problem with debugging is trying to re-create that event again we can see what exactly did the user do to even get that event

    - [Serilog] - we are using serilog which is a packaged used to log the information into a document, or other form.

7. What is [LINQ] and what is it used for?

    - LINQ Standardizes
    - [Language-Integrated-Query] - It is a query language that is very similar to SQL which we can use it in C# and it is incredibly useful for filtering/acquiring/Collect data
    - [LINQ] uses Query expressions are written in a declarative query syntax.
    - By using query syntax, you can perform filtering, ordering, and grouping operations on data sources with a samller amount of code.

8. what are the diffrent [SOLID] priciples?

    - [SOLID] design principles in C# are basic design principles. SOLID stands for [Single-Responsibility-Principle] (SRP), [Open-closed-Principle] (OSP), [Liskov-substitution-Principle] (LSP), [Interface-Segregation-Principle] (ISP), and [Dependency-Inversion-Principle] (DIP)
        - [Single-Responsibility-Principle] says "Every software module should have only one reason to change".
            - If one class has more responsibility, just segregate them into many classes
        - [Open-closed-Principle] - A class should be open for extensions but closed for modification
            - which means you can add new functionality without changing existing code

        - The [Liskov-substitution-Principle] states that "you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification".
            - It just means derived classes should not behave in such a way that it will not cause problems when used instead of a base class

        - The [Interface-Segregation-Principle] states "that clients should not be forced to implement interfaces they don't use.
            - Instead of one large interface, many small interfaces are preferred based on groups of methods
        - The [Dependency-Inversion-Principle] states that high-level modules and classes should not depend on low-level modules/classes. Both should depend upon abstractions.
            - and If a class uses the design and implementation of another class, it raises the risk that change one class could break the other class

9. What is a [Design-Pattern] and the types of [Design-Patterns]?

    - They are reusable solution that will solve the problems that occurs pretty frequently while coding
        - In essence people saw that problems were happening across multiple coders and decided to standardize a solution every time you come across to that problem to make your life easier

    - Design patterns have 3 Types of Design Pattern(3 Types)
        - [Creational] - these patterns deal with object creation and initialization.
            - Creational pattern gives the program more flexibility in deciding which objects needs to be created for a given case. [Singleton]
        - [Structural] - This pattern deals with class and object composition.
            -this is used to manage the structure of classes and interface as well as manage the relationship between the classes. [Adapter]
        - [Behavioural] - These patterns deal with communication between Classes and objects.
            - that means if you want to change the behavior of a class and you want it to affect other classes of the project as well.

10. What is [Singleton-Pattern]?

    - Singleton is a creational design pattern in C# is one of the most popular design patterns. In this pattern, a class has only one instance in the program that provides a global point of access to it. In other words, a singleton is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.
    [Advantages]
    - Provides a global point of access from multiple classes
    - It is easy to maintain since there is only one instance of that class
    [Disadvantages]
    - Very difficult to unit testing since it has global access
    - Definitely do not put any security sensitive information in a singleton
