# Chapter 4-6 Notes
### Author : Daniel Oszczapinski
<details><summary>Chapter 4 - Conditional Execution</summary>

	- Condition is an expression that evaluates the Boolean value
	- Conditions are used in loops and if statements 
	- if statements will execute the command if the condition is true, if false then the statement will not run the command.
	- elif statements allow for various possibilities and conditions
	- Logical AND (&&)- Will only run if the first command is successful 
	- Logical OR (||)- Will only run if the second command is not successful
	- Logical NOT (!) -Will test if the condition is true or not 
</details>

<details><summary>Special Parameters</summary>

    $* holds all command line parameters or arguments.
    $# holds the number of positional parameters.
    $- holds flags supplied to the shell.
    $? holds the return value set by the previously executed command.
    $$ holds the process number of the shell (current shell).
    $! hold the process number of the last background command.
    $@ holds all command line parameters or arguments.
</details>

<details><summary>Chapter 5: Bash Loops</summary>

	- Some commands allow the code to continue to run until the condition it met.
	- For loops run the commands and persist throughout the code.
 	- While loops continue to run until the condition is met. So if a code is ment to run 5 times the while loop with repeat the commands 5 times.
	- Infinite loops continue to run because the condition, if no code is implemented to stop the loop the user must manually stop the loop.
	- Until loop will execute until a nonzero returns and it will complete at least once.
	- Break statements can only be used in a *For*, *While* or *Until* loop.
	- A continue statement resumes the iteration of the code.
</details>

<details><summary>Chapter 6: Shell Redirection</summary>

    - A command will gather input from the user and produce an output but Linux allows files to be read as well.
    - A standard input, output and error are part of the default system.
    - Redirecting is possible with standard output and error into a file that a user can create.
</details>
