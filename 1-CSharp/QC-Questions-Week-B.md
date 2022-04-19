# Questions that maybe used in 1 on 1's or QC's.(There are 9 Questions from week B )

1. Types of Version Control Systems

    - [Local-VCS] - Saved by the local machine and always is acccessable by the developer but you have no backup available if something goes wrong and other developers cannot access the code you are working which mean that there will be less updates of the code.

    - [Centralized-VCS] - Code that is saved on the server which allows for multiple developers to access that code and make changes. Unfortuanatly, this vcs does merges all code into one repository.

    - [Distributedd-VCS] - We use git as out Distrubuted VCS.  The main code is also saved on a server similar to centralized but deverlopers are allowed to make their own server/Repository so they can work on the code locally. Developers can then branch the main code and then create a pull requests to allow push their code and once reviewed it can be merged. DVCS's also provide ever developer with the code history. Allows for multiple levels of protection.

2. Difference between the loops and statements ?

    - [For-Loop] - Exectutes a sequence of statements multiple times based on the condition given.(iteration)

    - [While-Loop] - It repeates statement or group of statements while a given condition is true, it tests the condition before executing the loop body.

    - [Do..While-Loop] - Similar to while loops execept it tests the condition at the end of the loop body. Meaning it will always print the first statement and then if condition is true it will repeat that statement.

    - [Foreach] - Executes a statement or a block of statements for each element in an array.

    - [If-statement] - will execute the statements based on the value of the boolean expression. [else] - the else in an if statment will execute when the boolean expression is not true. You can also [nest] if statements which will check multiple conditions.

    - [Switch-Case] - executes code of one of the conditions based on a pattern match with the specified match expression.

3. 3 Components of a .Net Framwork

    - [Languages] - First Level, these a .net compliant languages and Languages inclue c#, F#, Vb and more.

    - [Libraries] - Which are a collection of reusable types that are tightly integrate with the CLR. System.Object is a library used in .net.

    - [Runtime/CLR] - Manages memory, thread execution, code execution, compilation and
    - exception handling which are errors that occur when the application is executed. from the System.SystemException namespace.
    - garbage collection - process of removing unwanted resources where no logic requires.

4. LifeCycle of a program

    - The developer maching includes the .Net Compliant languages and C# is the language we are using.
    This then goes to the language specific compiler.
    Then the CIL or Common Intermidate Language creates a deployable code which is a exe and dLL which are non-readable.
    Then in the Target machine the DIL goes to the CLR(Common Language Runtime) which is the main engine of .Net.
    Finally it becomes machine code.

5. What are datatypes?

    - [Value-Type] - A variable of a value type contains an instance of the type. Value types value is store in the memory Stack
    The Predifined value types are int, long, short, and more
        Also [Structs] like a class but stored in the stack
        [Enums] defines a set of named integral constants

    - [Reference-Types] - They are datatypes that are stored in the heap and Variables of reference types store references to their (objects)
    Predefined -> string, arrays, collections etc, Classes, interface, Delegates.

6. What are the two types Conversion?

    - [Implicit-type-Conversion] - it is when you can convert the type without any data loss and Mostly used with numerical datatypes.
    [Boxing] is an implicit conversion of a value type to the type object
    or to any interface type implemented by this value type.

    - [Explicit-Type-Conversion] -The process is usually associated with information loss or failure to convert between types, you must perform a Cast
    [Unboxing] is an explicit conversion from the type object to a value type
    or from an interface type to a value type that implements the interface.

7. What are Collections ?

    - [Collections] - Specialized classes for data storage and retrieval. 

    - [Non-generic] collections store items as Object, require casting. Uses the System.Collections namespace. [ArrayList], [HashTable], [Stack], [queue]. 
    - [Generic] collections are type-safe at compile time. Because of this, generic collections typically offer better performance. Uses the System.Collection.Generic namepace
    Types of generic collections:
    - [Stack]
        - LIFO - It is a Last-in, First-out list
        - Major Operations
            - Push - Add element into stack
            - Pop - Remove an element from TOP
            - Peek - Retrieve the TOP element
    - [Queue]
        - FIFO - A first-in, first-out list
        - Major Operations
            - Enqueue - Add element into Queue
            - Dequeue - Remove element from Queue
            - Peek - Retrieve the TOP element
    - [List]
        - Like any array which can grow and shrink dynamically.
        - Items in the list can be accessed by index.
        - It can accept null as a valid value for reference types and it also allows duplicate elements.
        - List class is not sorted by default and elements are accessed by zero-based index.
        - Properties
            - Capacity - Gets or sets the total number of elements the internal data structure can hold without resizing.
            - Count - Gets the number of elements contained in the List
        - Methods:
            - Add(T) - Adds an object to the end of the List
            - Clear() - Removes all elements from the List
            - Insert(index, T) - Inserts an element into the List at the specified index
            - Remove(T) - Removes the first occurrence of a specific object from the List
            - RemoveAt(index) - Removes the element at the specified index of the List
            - Reverse() - Reverses the order of the elements in the List or a portion of it
    - [HashSet]
        - It is an unordered collection of the unique elements.
        - It prevent duplicates from being inserted in the collection.
    - [Dictionary]<Tkey,TValue>
        - It stores key/value pairs
        - Keys must be Unique
    - [SortedList]<TKey,TValue>
        - It is a sorted list of key/value pairs
    - [LinkedList]
        - It allows fast inserting and removing of elements. It implements a classic linked list.
        - Each element is separately allocated.
        - Properties:
            - Count - Gets the number of nodes actually contained in the LinkedList.
            - First - Gets the first node of the LinkedList.
            - Last - Gets the last node of the LinkedList.
        - Methods:
            - AddFirst - Adds a new node or value at the start of the LinkedList.
            - AddLast - Adds a new node or value at the end of the LinkedList.
            - Clear() - Removes all nodes from the LinkedList.
            - Contains(T) - Determines whether a value is in the LinkedList.
            - Remove(LinkedListNode) - Removes the specified node from the LinkedList.
            - Remove(T) - Removes the first occurrence of the specified value from the LinkedList.
            - RemoveFirst() - Removes the node at the start of the LinkedList.
            - RemoveLast() - Removes the node at the end of the LinkedList.

8. What is Exeption Handeling?

    - An [exception] is an event that occurs during the execution of a program that distrupts the normal flow of instructions

    - [Errors] - A serious problem that for the most part cannot be handled by the developer -They are fatal to the program at runtime
    - 3 types of errors
        - [Usage-error] - error in your program logic and can be solve by modifying/restructuring your code
        - [Program-Error] - run-time error that cannot be avoided even with a bug-free code (Ex: Your SDK is corrupt and can't compile or translate it to machine code properly)
        - [System-Failures] - run-time error that cannot be handled programmatically in a meaninful way (Ex: your ram hardware is faulty)

    - [Exception-Handling] - by handling exceptions gracefully so the user is provided with information as to why the application is not responding as anticipated for better user experience.
    - Using a [try-catch-block] and optionally finally block, The catch block will then "catch" that exception and will run instead its block of code which can tell the use how to fix their problem.
    - You can [throw-an-exception] yourself in your code by using the throw keyword
    - General rule is the most [specific] exception should be the very first catch block and the least specific exception is at the very last catch block.
