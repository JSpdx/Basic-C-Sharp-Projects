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
            Employee<string> employee1 = new Employee<string>() { firstName = "Mel", lastName = "Brooks", Id = 1 };
            Employee<string> employee2 = new Employee<string>() { firstName = "John", lastName = "Candy", Id = 2 };

            
            
            Employee<string> employee3 = new Employee<string>() { Things = new List<string> { "Mask", "Testing Kit", "Toilet Paper" } };
            Employee<int> employee4 = new Employee<int>() { Things = new List<int> { 12, 23, 324, 23 } };
            
            employee1.SayName();
            employee1.Quit();
            Console.WriteLine("Is " + employee1.firstName + " " + employee1.lastName + " currently employed? " + employee1.CurrentlyEmployed);

            //comparing employees by ID
            Console.WriteLine("Are these Employee objects the same?");
            Console.WriteLine(employee1 == employee2);               // Uses overloaded == operator
                                                                     //Console.WriteLine(employee1.Id == employee2.Id);      //Same thing as the line above



            //I couldn't figure out a good way to  Create a loop that prints all of the Things to the Console.
            //it's ugly but it technically works
            foreach (string thing in employee3.Things)
            {
                Console.WriteLine(thing);
                foreach (int otherThing in employee4.Things)
                {
                    Console.WriteLine(otherThing);
                }
                
            }


            Console.Read();

        }
    }
}
