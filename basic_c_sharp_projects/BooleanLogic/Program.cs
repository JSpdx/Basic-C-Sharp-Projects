using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine(" RECURSIVE Auto Insurance\n \"Don't call us, we'll call ourselves\"");
            
            Console.WriteLine("\nLet's enter some information to get started. What's your age?");
            byte age = byte.Parse(Console.ReadLine());
            
            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\"");
            bool hasDui = bool.Parse(Console.ReadLine());
            
            Console.WriteLine("How many tickets have you had in the last three years?");
            byte tickets = byte.Parse(Console.ReadLine());
            
            bool qualified;
            if (age > 15 && hasDui == false && tickets <= 3)
            {
                qualified = true;
                Console.WriteLine("Qualified " + qualified + "\nCongratulations! You qualify!");
            }
            else
            {
                qualified = false;
                Console.WriteLine("Qualified " + qualified + "\nYou don't qualify, here's a complimentary bucket to pick up your FACE!");
            }
            
            Console.ReadLine();
        }
    }
}
