using System;


namespace ShippingCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructiions below\n\nPlease enter your package weight");
            float weight = float.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.\nHave a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.WriteLine("Please enter your package width");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your package height");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your package length");
            float length = float.Parse(Console.ReadLine());

            if (height + width + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            decimal quote = Math.Round((decimal)weight * (decimal)width * (decimal)height * (decimal)length / 100, 2);
            
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\n Thank you.");
            Console.ReadLine();
            


        }
    }
}
