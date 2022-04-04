# History of Shell Scripting and Linux using markdowns
### Author : Daniel Oszczapinski
 This will be research the history of shell scripting, Linux, Shell programming, shell variables and environments.

1. <details><summary>History of Linux</summary>

    - Linux is an open- source operating system of Unix.
    - Unix is one of the most popular operating systems worldwide.  
    - October 5th, 1991, the first official version of Linux was announced.
    - Linux was written by Finnish American software engineer Linus Benedict Torvalds.
    - Linux can run on a wide range of hardware and can be installed alongside pre-existing systems
    - It requires low number of resources to run. 
    - A core component in Linux is kernel, which is developed independently from other operating system components.
    - Kernel allows the computer hardware and its processes to communicate efficiently. 
</details>

2. <details><summary>History of Shell Scripting</summary>

    - Bash is the shell or command language interpreter 
    - Shells are command line interpreters and was first created by Ken Thompson and uses the Unix shell.
    - Stephen Bourne created the first standard UNIX shell in 1979.
    - In 1988, Bourne introduced *bash*, which was the default shell for the Linux operating system.
    - This new shell gave way to more features and popularity to the system. 
    - The basic shell architecture looks like a pipeline.
    - You can manipulate files, execute programs, and print tests.
    - One of the best advantages of writing a shell script is that the commands and syntax are the same as the when entered in the command line.
    - Using a shell allows the user to customize their environment and setting their variables. 
    - Internalt commands part of shell iteself
    - External commands seperate binaries stored in directories '/usr/sbin
    - Kernel - The core of Linux operating system.
    - Shell - Provides an interface between the user and the kernel.
    - Terminal emulator - The xterm program is a terminal emulator for the X Window System. It allows user to enter commands and display back their results on screen.

</details>

3. <details><summary>Getting to know Shell Programming</summary>

    - Example of simple programing using shell  
    - Once this code is placed in a text document you can run the file
    - There are multiple ways to run the file you can use ./filename or a different command.

    ``` 
    echo "Hello, Everyone!"  
    echo "I hope you are doing well today."```
    
</details>

4. <details><summary>Chapter 3 - Shell Variables and Environment</summary>

    - The shell environment gives the user the ability to store commands in a file and build those function. 
    - In Linux shell scripting variables play an important role in system defined variables and user defined variables.
    - Variables are when you are referencing numeric or character values in your code.
    - The system defined variables are variables that are created in the operating system.
    - User defined variables are created by the user and stored temporarily for the use of that code. 
    - There are many commands that allow the user to set and use variables to code and get their desired outcome.
    - "	The double quote	The double quote ( "quote" ) protects everything enclosed between two double quote marks except $, ', " and "\.".Use the double quotes when you want only variables and command substitution.
        * Variable - Yes
        * Wildcards - No
        * Command substitution - yes
    -   '	The single quote	The single quote ( 'quote' ) protects everything enclosed between two single quote marks. It is used to turn off the special meaning of all characters.
        * Variable - No
        * Wildcards - No
        * Command substitution - No
    - \	The Backslash	Use backslash to change the special meaning of the characters or to escape special characters within the text such as quotation marks.
    - entering bash removes the instance of the variable from the local directory 
    - Use unset to remove variables from the current program
    - +	Addition
    - -	Subtraction
    - /	Division
    - *	Multiplication
    - %	Modulus
    - ++	post-increment (add variable value by 1)
    - --	post-decrement (subtract variable value by 1)
    - **	Exponentiation
    - Decalare command - sets a variable as a specified type, so if x is set to an integer then it connot be changed to a char type. 
    - readonly command or declare -r - creates a variable that will only output what is set and it connot be changed or deleted.
    - you can stop a code from executing by adding ${varName?Error varName is not defined} - this code stops the code when a variable is not defined. 
    - the history command produces the commands you used in bash.
    - alias command allows you to put a shortcut for other commands.
    - 
</details>
 
