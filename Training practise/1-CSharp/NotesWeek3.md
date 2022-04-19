# Notes for Week 3

* Notes involve architecture, OOP, access modifiers.

## App Architecture

* Grouping of code

### Solution

* The Final Grouping mechanism and will group multiple projects .

* Final Package of your application.

### Assembly

* Contains all the files that are actually executable.

### Project

* Contains all files that are compiled into an executable, library, etc.

### Namespaces

* Logical grouping of classes, must use 'using' keyword to access different classes.

### Classes

* They are the building blocks of your code.

* They are the blueprints to creating objects that your process in your program.

## OOP Definitions

    - There are two types of languages, [Procedural Oriented Languages] and [Object Oriented Programming].

    - [Procedural Oriented Languages] are: C, C++, Basic, Cobol
        - These focus on how to do it over what to do.
        - Code is scattered 
        - Data leak from garbage
        - Not friendly with reusability
    
    - OOP([Object Oriented Programming]): C#, Java, VB, TypeScript
        - Programming is more organized and better readability
        - suited well for large complex and actively updated programs
        -

## Structure of OOP

    - [Class]: Blueprint of user defined type which is mapped to real time entities.
    - [Object[]: an object is a implementation of the class 
    - Pillars of OOP [Encapsulation], [Abstraction], [Inheritance], [Polymorphism]

## The 4 Pillars of OOP

* [Encapsulation] - Wrapping up of the data and data hiding, to provide protection from the outside world. We use Access modifiers to provide various levels of access.

* [Abstraction] - Showing only essential features of the program instead on un-necessary details.

* [Inheritance] - Is a way to extend a type so that its properties and behaviors  can be extended/branched further.
  * Single - level: A->B
  * Multi - level: A->B->C
  * Hierarichal level A->B,C,D
  * Multiple inheritance(Not used very often) - (A,B)->C
  * Hybrid inheritance - Combination of more than one above types of inheritance.

* [Polymorphism] - Ability to implement inherited properties or methods in different ways across multiple abstractions.

  * [Method Overloading] is an example of compile time polymorphism, which is method with same name behaves differently based on signatures (parameters).  
  * [Method Overriding] is an example of runtime polymorphism, which is re-defining the method of parent class into child class.

### Method Overloading

* known as static or compile time polymorphism

* Overloading is the ability to have multiple methods within the same class with the same name, but with different parameters.

### Method Overriding

* known as dynamic/runtime polymorphism.

* Overriding, on the other hand, is the ability to redefine the implementation of a method in a class that inherits from a parent class.

## Abstract Class vs Interface

### Interface

* An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface. *But interfaces will contain only the declaration of the members. The implementation of interface’s members will be given by the class who implements the interface implicitly or explicitly.*

* But interface can only have methods, properties, events, indexers, but that means interfaces cannot have variables or methods with implementation

### Abstract class

* Abstract class allows you to implement a spectrum of abstraction like full abstraction, partial abstraction. *An Abstract class is never intended to be instantiated directly.*

* Abstract class allows you to have all types of members. Like you can have data variables and assign values to it and can create methods with definition.

### Both Interface and Abstract Class

* Abstract class and interface cannot be instantiated but meant to be implemented/inherited

* Abstract/Concrete class can implement one or more interfaces by which multiple inheritance is achieved. But class can only inherit from 1 class

* Abstract class and interface cannot be instantiated but meant to be implemented/inherited

## Access Modifiers
Caller's location	      public |	protected| internal|	protected	internal|	private protected	| private
Within the class	        ✔️️  |     ✔️    |   ✔️    |         ✔️        |        ✔️        |    ✔️
Derived class 
(same assembly)	          ✔️  |     ✔️    |   ✔️    |         ✔️        |        ✔️        |    ❌
Non-derived class 
(same assembly)	          ✔️  |     ✔️    |   ❌    |         ✔️        |        ❌        |    ❌
Derived class 
(different assembly)	    ✔️  |    ✔️     |   ✔️    |         ❌        |        ❌        |    ❌
Non-derived class 
(different assembly)	    ✔️  |    ❌     |   ❌    |         ❌        |        ❌        |    ❌

* [Public]

  * The type or member can be accessed by any other code in the same assembly or another assembly that references it.

* [Private]

  * The type or member can be accessed only by code in the same class or struct.

* [protected]

  * The type or member can be accessed only by code in the same class, or in a class that is derived from that class.

* [internal]

  * The type or member can be accessed by any code in the same assembly, but not from another assembly. In other words, internal types or members can be accessed from code that is part of the same compilation.

* [protected-internal]

  * The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.

* [private-protected]

  * The type or member can be accessed by types derived from the class that are declared within its containing assembly.

* [Abstract]

  * Enables you to create incomplete implementation of whatever you applied it to and it must be implemented in a derived class
  * Implicitly used by interfaces
  * Explicitly used by abstract classes

* [Static]

  * Static classes cannot be instantiated or inherited, its members must also be static
  * Static class members belongs to the class itself rather than to a specific object

* [Readonly]

  * Readonly fields cannot change its value once it is set

* [Override]

  * Override methods must do method overriding or the compiler will notify you that it isn't

* [Virtual]

  * Allows the method for the base class to be overriden
  * Essential for method overriding for polymorphism

* [Struct]

  * Unlike classes, struct gets stored in the stack memory so they are more optimized and efficient

* [Nullable]

  * Makes datatypes optional and it is denoted by using '?'

  * Hence the name nullable, it makes whatever datatype have an option to also hold a null value

### Default Modifiers

* Classes, records, and structs declared directly within a namespace (in other words, that aren't nested within other classes or structs) can be either public or internal.
* [Internal] is the default if no access modifier is specified.  

* Struct members, including nested classes and structs, can be declared public, internal, or private. Class members, including nested classes and structs, can be public, protected internal, protected, internal, private protected, or private.
* Class and struct members, including nested classes and structs, have [private] access by default.

## SOLID Principle

* [SOLID] design principles in C# are basic design principles. SOLID stands for [Single-Responsibility-Principle] (SRP), [Open-closed-Principle] (OSP), [Liskov-substitution-Principle] (LSP), [Interface-Segregation-Principle] (ISP), and [Dependency-Inversion-Principle] (DIP)

  * [SRP] says "Every software module should have only one reason to change".

  * The [LSP] states that "you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification".

  * The [ISP] states "that clients should not be forced to implement interfaces they don't use. Instead of one fat interface, many small interfaces are preferred based on groups of methods, each one serving one submodule.".

  * The [DIP] states that high-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions. Secondly, abstractions should not depend upon details.

## Singleton Design Pattern

* Singleton design pattern in C# is one of the most popular design patterns. In this pattern, a class has only one instance in the program that provides a global point of access to it. In other words, a singleton is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.
