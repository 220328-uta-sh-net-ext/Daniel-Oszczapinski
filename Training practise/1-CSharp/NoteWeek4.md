# Notes for Week 4

## Generics

* [Generics] - Makes it possible to design classes and methods that defer the specifications of one or more types until the class or methods is declared and instatiated.
  * By using generics you can get strongly typed code and performance is improved becuase you do not have to do boxing or unboxing.

## Serialization

* [Serialization] - is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database or file.
  * its main purpose is to save the state of an object in order to be able to recreate it when needed.
  * The reversed is called [Deserialization]

### Json Serialization

* [Json-Serialization](Javascript Object Notation) - Open standard that is used commonly for sharing data accross the web. Reduces data and currently popular

### Binary and XML Serialization

* [Binary] - Uses binary encoding to produce compact serialization for storage and streams, problem with security
* [XML] - Serialization the public field and properties of an object and return values of methods into xml stream, Not very readable and losts of data when code gets larger.

## SDLC - Software Development Life Cycle

* Phases are [Requirement-Analysis], [Design], [Development], [Testing], [Deployment], [Maintainence]
  * Models to help with SDLC, waterfalls, extreme programming, agile, and TDD(Test Driven Development)

### Models of SDLC(Most of these will be discussed on Week 5)

* Waterfalls
* Extreme Programming
* Agile
* TDD - Test Driven Development

## Testing

* Type of testing Performance Testing, Load Testing, Smoke testing, Integration Testing, Penetration Testing, Unit Testing.

## Flow of TDD

1. Create a test case
2. Running the test case will fail the first time -
3. Write code so the new test case will pass
4. Make sure old test cases won't fail because of the new feature
5. Clean up the code and have proper documentation for other developers
6. Repeat

* [Unit-Testing] - Check that your code is working as expected by creating and running unit tests. It's called unit testing because you break down the functionality of your program into discrete testable behaviors that you can test as individual units.
  * Like the word "Unit", you will test a small portion of your code to ensure it is working. Helpful to check that particular section of your code is working

* Test-driven development (TDD) is a software development process relying on software requirements being converted to test cases before software is fully developed, and tracking all software development by repeatedly testing the software against all test cases. This is as opposed to software being developed first and test cases created later.
  * [Arrange] - This is where you initiliaze objects or some values you will need for the test
  * [Act] - Invokes the method/function under the test with the arranged objects/values
  * [Assert] - Verifies that the action of the method under the tests behaves as expected

## Code Coverage

* It is the percentage given to you on how much lines of your code is actually covered by unit testing we are using Coverlet to see the coverage percentage.

## Logging

* The systematically way to record a series of events depending on what exactly you are trying to capture
  * Logging user events

* The main purpose is for debugging potential bugs since the main problem with debugging is trying to re-create that bug again just to see what exactly did the user did to even get that bug

* [Serilog] - a packaged used to log the information into a document, or other form.

## LINQ(Language Integrated Query)

* It is a query language that is very similar to our SQL but we can use it in C# or VB
  * So like any query langauge, it is incredibly useful for filtering/acquiring/aggregating data

## SOLID Principle

* [SOLID] design principles in C# are basic design principles. SOLID stands for [Single-Responsibility-Principle] (SRP), [Open-closed-Principle] (OSP), [Liskov-substitution-Principle] (LSP), [Interface-Segregation-Principle] (ISP), and [Dependency-Inversion-Principle] (DIP)
  * [SRP] says "Every software module should have only one reason to change".
  * The [LSP] states that "you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification".
  * The [ISP] states "that clients should not be forced to implement interfaces they don't use. Instead of one fat interface, many small interfaces are preferred based on groups of methods, each one serving one submodule.".
  * The [DIP] states that high-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions. Secondly, abstractions should not depend upon details.

## Design Pattern

* They are reusable solution that will solve the problems that occurs pretty frequently while coding
  * Essentially, some people saw that problem keeps happening across multiple coders and decided to standardize a solution every time you come across to that problem to make your life easier

* Types of Design Pattern(3 Types)
  * [Creational] - hese patterns deal with object creation and initialization. Creational pattern gives the program more flexibility in deciding which objects need to be created for a given case.
  * [Structural] - This pattern deals with class and object composition. In simple words, This pattern focuses on decoupling interface, implementation of classes and its objects.
  * [Behavioural] - These patterns deal with communication between Classes and objects.

### Singleton Design Pattern

* Singleton design pattern in C# is one of the most popular design patterns. In this pattern, a class has only one instance in the program that provides a global point of access to it. In other words, a singleton is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.

Advantages:

* Provides a global point of access from multiple classes
* It is easy to maintain since there is only one instance of that class

Disadvantages:

* Very difficult to unit testing since it has global access
* Definitely do not put any security sensitive information in a singleton
