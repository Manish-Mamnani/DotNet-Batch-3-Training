// See https://aka.ms/new-console-template for more information
using System;
using Day3Console;



Person person = new Person();
Person person2 = new Person();

//Boxing & UnBoxing
int num1 = 120;
object op = num1; //Boxing (Value to Ref)

int num2 = (int)op; //UnBoxing (Ref to Value)