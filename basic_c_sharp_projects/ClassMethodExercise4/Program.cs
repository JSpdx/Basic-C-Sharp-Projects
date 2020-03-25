﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This exercise uses named arguments and a void method
namespace ClassMethodExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.stuff(3, 324);
            class1.stuff(first: 3, second: 34);
            Console.ReadLine();
        }
    }
}

//1. Create a class. In that class, create a void method that takes two integers as 
//parameters.Have the method do a math operation on the first integer and display the second integer to the screen.

//2. In the Main() method of the console app, instantiate the class.

//3. Call the method in the class, passing in two numbers.

//4. Call the method in the class, specifying the parameters by name.