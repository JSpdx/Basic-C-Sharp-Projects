using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise with method overloads



namespace ClassMethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations1 = new Operations();
            Console.WriteLine(operations1.mathStuff(3));

            Operations operations2 = new Operations();
            Console.WriteLine(operations2.mathStuff(3, 23.32m));

            Operations operations3 = new Operations();
            Console.WriteLine(operations3.mathStuff(5, 23.6m, "34"));

            Console.ReadLine();





        }
    }
}
