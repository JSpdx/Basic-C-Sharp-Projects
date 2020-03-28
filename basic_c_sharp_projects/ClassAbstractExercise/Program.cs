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
            Employee employee1 = new Employee() { firstName = "Mel", lastName = "Brooks", Id = 1 };

            Employee employee2 = new Employee() { firstName = "John", lastName = "Candy", Id = 2 };
            
            employee1.SayName();
            employee1.Quit();
            Console.WriteLine("Is " + employee1.firstName + " " + employee1.lastName + " currently employed? " + employee1.CurrentlyEmployed);

            //comparing employees by ID
            Console.WriteLine("Are these Employee objects the same?");
            Console.WriteLine(employee1 == employee2);               // Uses overloaded == operator
            //Console.WriteLine(employee1.Id == employee2.Id);      //Same thing as the line above

            Console.Read();

        }
    }
}
