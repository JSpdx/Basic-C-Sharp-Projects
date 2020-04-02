using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            int age = 1;
            while (!isValid)
            {
                try
                {
                    Console.WriteLine("Please enter your age:\n");
                    isValid = int.TryParse(Console.ReadLine(), out age);
                    if (!isValid) Console.WriteLine("Please enter a valid age.");
                    if (age <= 0)
                    {
                        throw new AgeException("User entered a number smaller than 0");
                    }
                    DateTime date = DateTime.Now;
                    TimeSpan years = new TimeSpan(age * 365, 0, 0, 0, 0);
                    DateTime yearBorn = date - years;
                    Console.WriteLine("You were born in the year {0}", yearBorn.Year);
                    Console.ReadLine();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number you entered was too high");
                    isValid = false;
                }
                catch (AgeException)
                {
                    Console.WriteLine("Please enter a non decimal number larger than 0");
                    isValid = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Looks like something went wrong.");
                    isValid = false;
                }
            }
        }
    }
}
