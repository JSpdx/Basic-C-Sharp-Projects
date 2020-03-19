using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FiggleFonts.Mini.Render("Anonymous Income Comparison Program"));
            
            Console.WriteLine("\nPerson 1");
            Console.WriteLine("Enter hourly rate. (ex 21.12)");
            string rateInputOne = Console.ReadLine();
            decimal personOneRate = Convert.ToDecimal(rateInputOne);
            Console.WriteLine("Enter their hours worked for the week");
            string hoursInputOne = Console.ReadLine();
            float personOneHours = Convert.ToSingle(hoursInputOne);

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Enter hourly rate. (ex 21.12)");
            string rateInputTwo = Console.ReadLine();
            decimal personTwoRate = Convert.ToDecimal(rateInputTwo);
            Console.WriteLine("Enter their hours worked for the week");
            string hoursInputTwo = Console.ReadLine();
            float personTwoHours = Convert.ToSingle(hoursInputTwo);

            Console.WriteLine("\nAnnual Salary of Person 1");
            Console.WriteLine((float)personOneRate * personOneHours * 52);

            Console.WriteLine("\nAnnual Salary of Person 2");
            Console.WriteLine((float)personTwoRate * personTwoHours * 52);

            float P1annual = (float)personOneRate* personOneHours *52;
            float P2annual = (float)personTwoRate * personTwoHours * 52;
            Console.WriteLine("\nDoes Person 1 make more money than Person 2 ?");
            Console.WriteLine(P1annual > P2annual);



            Console.ReadLine();
        }
    }
}
