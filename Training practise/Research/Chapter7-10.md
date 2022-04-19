# Chapter 7-10 Notes
### Author : Daniel Oszczapinski
<details><summary>Chapter 7: Pipes and Filters</summary>
    - In command line these commands will work.
        - ; > Separates commands that are executed in sequence. 'date ; pwd'
        - & > The shell executes the command in the background in a subshell. The shell does not wait for the command to finish, and the return status is 0. The & operator runs the command in background while freeing up your terminal for other work. 'find / -iname "*.pdf" >/tmp/output.txt &'
        - && > command2 is executed if, and only if, command1 returns an exit status of zero i.e. command2 only runs if first command1 run successfully.
        - || > command2 is executed if and only if command1 returns a non-zero exit status i.e. command2 only runs if first command fails
        - | > Linux shell pipes join the standard output of command1 to the standard input of command2. 'ps aux | grep httpd'
    - Putting Jobs in the background
        - The bash shell allows you to run tasks (or commands) in the background using the facility called job control.]
        - Job control refers to the ability to selectively stop, suspend the execution of processes and continue (resume) their execution at a later point.
        - A user typically employs this facility via an interactive interface supplied jointly by the system’s terminal driver and bash.
        - *fg* - Place job in the foreground.
        - *bg* - Place job in the background.
        - *jobs* - Lists the active jobs on screen.
    - A shell *pipe* is a way to connect the output of one program to the input of another program without any temporary file.
    - Use the vertical bar (|) between two commands. In this example, send ls command output to grep command 
    - The input *<* redirection symbol can be used with pipes to get input from a file
    - If a Linux command accepts its input data from the standard input and produces its output (result) on standard output is known as a filter.
    - Filters usually works with Linux pipes.
</details>

<details><summary>Chapter 8: Traps</summary>
    - This chapter talkes sbout the process the operating system uses in more detail.
    - You need to use the *trap* command to catch signals and handle errors under Linux shell scripts.
    - *Kill* command stops process that is specified.
    - *killall* sends a signal to all processes running any of the specified commands . If no signal name is specified, SIGTERM is sent. To terminate all firefox process (child and parent).
    - The *pkill* command is another command with additional options to kill process by its name, user name, group name, terminal, UID, EUID, and GID. It will send the specified signal (by default SIGTERM) to each process instead of listing them on stdout. To send a kill signal to php-cgi process.
    - User can also stop the process by pressing *CTRL+Z*.
    - Whenever you run a shell script, it creates a new process called subshell and your script will get executed using a subshell.
    - A Subshell can be used to do parallel processing.
    - Use *exec* command to replace the shell with the given command. The exec command is used to replace the current shell with the command without spawning a new process or subshell.
</details>

<details><summary>Chapter 8: Traps</summary>
    - To *display* defined function names use the declare command.
    - A recursive function is a function that repeatedly calls itself.
    - No limit is placed on the number of recursive calls.
</details>