#! /usr/bin/bash
# single line comment
: '
this is 
multi-line 
comment
'

#shebang/hash bang - mentions which shell to be used and its location in OS


# print Hello world when this file is run
echo "hello world"

# System defined variables 
# " " are optional, they make the code look better
echo "My shell name is $BASH"
echo "My shell version $BASH_VERSION"
echo "My current directiory is $PWD"
echo "my home directory is $HOME"

# User defined variables, use A-Z, a-z, 0-9 or _
name=Daniel
echo "The name is $name"
_USD=200
echo "Ths value is $_USD"

_USD=150
echo "This changed value is $_USD"

pi=3.14
readonly pi # Locks the value and it connot be changed or unset
#unset pi -> unset is used to remove a value 
#pi=22.7
echo "The value of pi is $pi"
