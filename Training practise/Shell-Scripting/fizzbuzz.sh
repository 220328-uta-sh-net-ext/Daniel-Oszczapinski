#! /usr/bin/bash
function Fizzbuzz {

read -r -p "What is your number: " number # Allows user to choose a number
if (( number <=0 )) || (( number >= 21 )) # If you choose a number not from 1-20 you will get a message to choose another number.
then
    echo "Choose a number 1-20!"
    elif ((number%5 == 0 )) && ((number%3 == 0)) # If else statement that will verify if a number is divisible by 3 and 5. 
    then
        echo "Fizzbuzz!"

    elif ((number % 5 == 0)) # Checks if number is divisible by 5.
    then
        echo "Buzz!"
        

    elif ((number % 3 == 0)) # Checks if number is divisible by 3.
    then
        echo "Fizz!"
    
    elif ((!number % 3 == 0)) || ((!number % 5 == 0)) # Checks if the number is not dvisible by 3 or 5.
    then
        echo "Nothing!"
    
fi
}

quit=n
while [[ "$quit" != q ]]
do 
    Fizzbuzz
    read -r -p "Press 'enter' to try again or 'q' to 
    quit: " quit
done
