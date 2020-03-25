using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodExercise2
{
    class Operations
    {
        public int mathStuff(int x)
        {
            return x * x;
        }

        public decimal mathStuff(int x, decimal y)
        {
            return x * x * x;
        }

        public int mathStuff(int x, decimal y, string z)
        {
            int convertedInt = Convert.ToInt32(z);
            int result = convertedInt * 42;
            return result;
        }


    }
}
