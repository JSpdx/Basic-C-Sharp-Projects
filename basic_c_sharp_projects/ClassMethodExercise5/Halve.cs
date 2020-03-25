using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodExercise5
{
    static class Halve
    {
        public static void DivideByTwo(float x)
        {
            float quotient = x / 2;
            Console.WriteLine(x + " / " + 2 + " = " + quotient);
        }
    
        public static string DivideByTwo(float x, int times)
        {
            float numerator = x;
            for (int i = 0; i < times; i++)
            {
                x = x / 2;   
            }
            return numerator + " / 2, " + times + " times, equals " + x; 
        }

    }
}
