using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        { 
            //this program prints the current time, asks the user for a number, then prints
            //the time after that many hours have passed.
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(num));
            Console.ReadLine();

        }
}
}
