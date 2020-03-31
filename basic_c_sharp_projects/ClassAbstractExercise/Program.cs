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
            Employee<string> employee3 = new Employee<string>() { firstName = "Chris", lastName = "Farley", Id = 3 };
            Employee<string> employee4 = new Employee<string>() { firstName = "Dave", lastName = "Chappelle", Id = 4 };
            Employee<string> employee5 = new Employee<string>() { firstName = "Joe", lastName = "Rogan", Id = 5 };
            Employee<string> employee6 = new Employee<string>() { firstName = "Eddie", lastName = "Murphy", Id = 6 };
            Employee<string> employee7 = new Employee<string>() { firstName = "Mitch", lastName = "Hedberg", Id = 7 };
            Employee<string> employee8 = new Employee<string>() { firstName = "Richard", lastName = "Pryor", Id = 8 };
            Employee<string> employee9 = new Employee<string>() { firstName = "George", lastName = "Carlin", Id = 9 };
            Employee<string> employee10 = new Employee<string>() { firstName = "Robin", lastName = "Williams", Id = 10 };

            List<Employee<string>> employeeList = new List<Employee<string>>()
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7,
                employee8,
                employee9,
                employee10
            };
            
            //List<Employee<string>> joeList = new List<Employee<string>>();  
            //foreach (Employee<string> employee in employeeList)
            //{
            //    if (employee.firstName == "Joe")
            //    {
            //        joeList.Add(employee);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}              

            
            List<Employee<string>> joeList = employeeList.Where(x => x.firstName == "Joe").ToList();
            Console.WriteLine(employeeList.Contains(employee5));

            List<Employee<string>> idOverFive = employeeList.Where(x => x.Id >= 5).ToList();
            foreach (Employee<string> employee in idOverFive)
            {
                employee.SayName();
            }





            //Employee<string> employee3 = new Employee<string>() { Things = new List<string> { "Mask", "Testing Kit", "Toilet Paper" } };
            //Employee<int> employee4 = new Employee<int>() { Things = new List<int> { 12, 23, 324, 23 } };

            // employee1.SayName();
            //employee1.Quit();
            // Console.WriteLine("Is " + employee1.firstName + " " + employee1.lastName + " currently employed? " + employee1.CurrentlyEmployed);

            //comparing employees by ID
            // Console.WriteLine("Are these Employee objects the same?");
            //Console.WriteLine(employee1 == employee2);               // Uses overloaded == operator
            //Console.WriteLine(employee1.Id == employee2.Id);      //Same thing as the line above



            //I couldn't figure out a good way to  Create a loop that prints all of the Things to the Console.
            //it's ugly but it technically works
            //foreach (string thing in employee3.Things)
            //{
            //    Console.WriteLine(thing);
            //    foreach (int otherThing in employee4.Things)
            //    {
            //        Console.WriteLine(otherThing);
            //    }

            //}


            Console.Read();

        }
    }
}
