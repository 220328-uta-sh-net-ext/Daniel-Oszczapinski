#! /usr/bin/bash
read USER
read movie
echo "Hello $USER"
echo -e "Today is \c ";date
echo -e "Number of user login : \c" ; who | wc -l
echo "your favorite movie is: $movie"
exit 0