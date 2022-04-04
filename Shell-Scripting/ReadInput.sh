#! /usr/bin/bash

##echo "Enter your name: "
##read name #takes input from user and saves its value into variable
##echo "Hello $name"

#crtl+k+c to comment the selection
#ctrl+k+u to uncomment the slection

# Arrays - Multi collection of values placed one after another(Indexed)
##echo "Enter names"
##read -a names
##echo "The names are: ${names[0]}, ${names[1]}, ${names[2]}"

read -r -p 'Username: ' username # -p Stands for print
read -r -sp 'Password: ' password # -sp stands for secure print
echo
echo "username is $username"
echo "password is $password"