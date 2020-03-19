using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and I will perform some calculations on it!: ");
            
            string rawInput = Console.ReadLine();
            decimal userInput;
            userInput = Convert.ToDecimal(rawInput);
            
            decimal timesFifty = userInput * 50;
            decimal plusTwentyFive = userInput + 25;
            decimal divideByTwelvePointFive = userInput / (decimal)12.5;
            bool isGreaterThanFifty = userInput > 50;
            decimal remainderFromSeven = userInput % 7;

            Console.WriteLine(userInput + " X 50 = " + timesFifty);
            Console.WriteLine(userInput + " + 25 = " + plusTwentyFive);
            Console.WriteLine(userInput + " / 12.5 = " + divideByTwelvePointFive);
            Console.WriteLine(userInput + " > 50? " + isGreaterThanFifty);
            Console.WriteLine("The remainder of " + userInput + " / 7 = " + remainderFromSeven);
            Console.ReadLine();

        }
    }
}
