using System;

namespace CountToOneHundred
{
    class Program
    {
        static void Main()
        {
            int x = 0;
            while ( x < 100)
            {
                x += 1;
                Console.WriteLine(x);
            }
            Console.WriteLine("Hit Enter to go back down");
            Console.ReadLine();
            
            do
            {
                x -= 1;
                Console.WriteLine(x);
            }
            while (x > 0);
            Console.ReadLine();

        }

    }
}
