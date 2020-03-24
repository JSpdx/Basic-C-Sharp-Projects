using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to do operations on?");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x + " cubed = "+ Operations.cubed(x));
            Console.WriteLine(x + " squared = " + Operations.squared(x));
            Console.WriteLine(x + " doubled = " + Operations.doubled(x));
            Console.ReadLine();
        }
    }
}
