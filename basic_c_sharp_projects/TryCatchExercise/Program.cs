using System;
using System.Collections.Generic;
namespace TryCatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numList = new List<int>() { 1, 324, 4, 12, 7634, 3, 32 };
                Console.WriteLine("Please enter a denominator");
                int denominator = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numList)
                {
                    Console.WriteLine(num + "/" + denominator + " = " + num / denominator);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero poindexter!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Now that we're done with the Try/Catch block, some other stuff can happen");
                Console.ReadLine();
            }
        }
    }
}
    //Assignment

    //1.Create a list of integers. Ask the user for a number to divide each number in the list by.
    //Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.


    //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.


    //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.


    //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.


    //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, 
    //make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.
    //In the catch block, display the error message to the screen.Then try various combinations of user input: 
    //valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
