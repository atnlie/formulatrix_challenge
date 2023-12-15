Formulatrix Challenge
=======================

1. Write a simple console program that prints the number from 1 to n, 
for each number x :
print "foo", if x is divisible by 3
print "bar", if x is divisible by 5
print "foobar", if x is divisible by 3 and 5
print the number itself, if x satisfies none of the rule
Here's a sample output of such program with n=15
>> 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar

Refer to branch `1-coding-competency`

2. Continuing on the previous question. Add the following rules
print "jazz", if x is divisible by 7
This means for x=21, x=35 and x=105 the program should print "foojazz", "barjazz" and
"foobarjazz" respectively.

Refer to branch `2-coding-competency`


3. Continuing on the previous question. Using the same divisible logic, use the table below as
the rules
3 : "foo"
4 : "baz"
5 : "bar"
7 : "jazz"
9 : "huzz"

Refer to branch `3-coding-competency`

4. Turn the generator logic in the code you have so far into a class object and make it so that
the client code can configure its own rules i.e. add the following API

myClass.AddRule( int input, string output )

Refer to branch `4-coding-competency`