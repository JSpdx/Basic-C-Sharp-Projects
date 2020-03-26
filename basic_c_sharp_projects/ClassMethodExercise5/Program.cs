using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Exercise using void methods and static classes
namespace ClassMethodExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Halve.DivideByTwo(3);

            Console.WriteLine(Halve.DivideByTwo(100, times: 2));

            Console.Read();
        }
    }
}
