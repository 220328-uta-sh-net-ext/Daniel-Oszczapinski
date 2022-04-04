#! /usr/bin/bash

sum=0
a=0
b=1
read -r -p "What is your number: " f
if (( f > 0 && f <= 40))
then 
    for (( i=0; i<f-1; i++ ))
    do
  
        #echo "$a "
        fn=$((a + b))
        a=$b
        b=$fn
        
    done
    
else
    echo "choose number 0 to 40."
fi
c=$((b+f))
fsum=$((sum+b))
sum=$((sum+c))
final=$((fsum-sum))
echo -n "$b"
