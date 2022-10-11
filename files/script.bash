#! /bin/bash
echo 'Type your username'
read name
if [ $name == "robert" ]
then
    if [ -f "hello.txt" ]
    then
        echo "Hello, $name"
    else
        echo "Hello, student of 1 group Kish Robert Robertovych"
        fi
else
    echo 'Invalid username'
fi