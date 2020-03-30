using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a day of the week");
            bool complete = false;
            while (complete != true)
            {

                
                try
                {
                    string userDay = Console.ReadLine();
                    userDay = userDay.ToLower();
                    Days day = (Days)Enum.Parse(typeof(Days), userDay);
                    Console.WriteLine("You entered:\n"+ day);
                    complete = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            Console.Read();

        }
        enum Days
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
