using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to log");
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Jon\OneDrive\Desktop\Github Repos\Basic-C-Sharp-Projects\basic_c_sharp_projects\IOExercise\TextFile1.txt", num);
            Console.WriteLine(File.ReadAllText(@"C:\Users\Jon\OneDrive\Desktop\Github Repos\Basic-C-Sharp-Projects\basic_c_sharp_projects\IOExercise\TextFile1.txt"));
            Console.Read();

        }
    }
}
