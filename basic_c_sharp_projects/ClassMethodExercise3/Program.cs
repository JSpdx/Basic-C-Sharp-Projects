using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exercise for using optional parameters
// had to use try/catch for cases when user didn't input anything.

namespace ClassMethodExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            Console.WriteLine("Let's add some numbers. The second number is optional");
            int x = Convert.ToInt32(Console.ReadLine());
            try
            {
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(operations.add(x, y));
            }
            catch (FormatException)
            {
                Console.WriteLine(operations.add(x));
            }
            Console.ReadLine();
        }
    }
}
