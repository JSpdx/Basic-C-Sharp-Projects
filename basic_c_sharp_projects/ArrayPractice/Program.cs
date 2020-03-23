using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main()
        {
            string[] progArray = new string[4];
            progArray[0] = "\nYES";
            progArray[1] = "\nRush";
            progArray[2] = "\nKing Crimson";
            progArray[3] = "\nFrank Zappa";

            int[] intArray = new int[3];
            intArray[0] = 123;
            intArray[1] = 5234;
            intArray[2] = 412;

            bool appExit = false;
            while (appExit == false)
            {
                try
                {
                    Console.WriteLine("Select a number between 0 and 3:");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(progArray[i]);
                    
                    Console.WriteLine("\nPick a number between 0 and 2:");
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine(intArray[i]);
                    
                    appExit = true;
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("Oops! Looks like your number was out of range. Try again!");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Oops! You didn't enter anything. Try again!\n");
                }
            }

            List<string> lotrTitles = new List<string>();
            lotrTitles.Add("\nThe Fellowship of the Ring");
            lotrTitles.Add("\nThe Two Towers");
            lotrTitles.Add("\nThe Return of the King");

            Console.WriteLine("\nPick a number between 0 and 2:");
            int userIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(lotrTitles[userIndex]);



            Console.ReadLine();
            System.Environment.Exit(0);
        }
    }
}
