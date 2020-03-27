using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Mel", lastName = "Brooks" };
            employee.SayName();
            employee.Quit();
            Console.WriteLine("Is " + employee.firstName + " " + employee.lastName + " currently employed? " + employee.CurrentlyEmployed);
            Console.Read();

        }
    }
}
