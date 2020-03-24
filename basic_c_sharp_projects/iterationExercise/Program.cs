using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Step 1: 

            //string[] strArray = new string[] { "Hello ", "What are you doing ", "I'm afraid I can't open the pod bay doors " };
            //Console.WriteLine("Please enter your name");
            //string name = Console.ReadLine();
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    strArray[i] = strArray[i] + name;
            //    Console.WriteLine(strArray[i]);
            //}


            //Step 2:

            //while (true)
            //{
            //    Console.WriteLine("Oh no!");
            //}
            //Console.WriteLine();


            //Step 3:

            //while (true)
            //{
            //    Console.WriteLine("Oh no!");
            //    int count = 1;            ////Lines 39 to 43 will fix the loop
            //    if (count == 1) ;
            //    {
            //        break;
            //    }
            //   Console.Readline();  
            //}


            //Step 4:
            //Your sound should be on for this

            //for (int i = 1; i < 20; i++)
            //{
            //    Console.Beep(i * 200, 150);
            //}


            //Step 5:

            //for (int i = 1; i <= 40; i++ )
            //{
            //    Console.WriteLine("JAZZ");
            //    Console.SetCursorPosition(i * 2, i + 1);
            //}
            //Console.Read();


            //Step 6, 7, 8:

            //List<string> farmAnimals = new List<string>() {"cow", "chicken", "rooster", "horse", "sheep", "pig", "goat"};
            //Console.WriteLine("Enter in a type of farm animal");
            //string userEntry =  Console.ReadLine().ToLower();
            //int counter = 0;
            //for (int i = 0; i < farmAnimals.Count; i++)
            //{
            //    if (farmAnimals[i].Contains(userEntry))
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //    if (!farmAnimals[i].Contains(userEntry))
            //    {
            //        counter++;
            //        if (counter == farmAnimals.Count)
            //        {
            //            Console.WriteLine("Looks like there was no match");
            //        }
            //    }
            //}
            //Console.ReadLine();


            //Step 9:

            List<string> names = new List<string>() {"Bob", "Karen", "LaToya", "Manuel", "LaToya", "Bob" };
            Console.WriteLine("Enter a name");
            string userEntry = Console.ReadLine().ToLower();
            int counter = 0;
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
                if (names[i].Contains(userEntry))
                {
                    Console.WriteLine("aasd");
                    Console.WriteLine(i);
                    
                }
                //if (!names[i].Contains(userEntry))
                //{
                //    Console.WriteLine("sdf");
                //    counter++;
                //    if (counter == names.Count)
                //    {
                //        Console.WriteLine("looks like your text wasn't in the list");
                //    }
                //}
            }
            Console.ReadLine();
        }
    }
}
//            IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

//1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array,
//   adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line.

//2. Create an infinite loop.

//3. Fix the infinite loop so it will execute.

//4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

//5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

//6. Create a List of strings where each item in the list is unique. Ask the user to input text to search for in the List.
//   Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.

//7. Add code to that above loop that tells a user if they put in text that isn’t in the List.

//8. Add code to that above loop that stops it from executing once a match has been found.

//9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
//   create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.

//10. Add code to that above loop that tells a user if they put in text that isn’t in the List.

//11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list,
//   and displays a message showing the string and whether or not it has already appeared in the list.
