using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractExercise
{
    public class Employee<T> : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            CurrentlyEmployed = false;
        }

        public void PrintThings()
        {
            foreach ( T thing in Things)
            {
                Console.WriteLine(thing);
                Console.ReadLine();
            }
        }
        
        
        public List<T> Things { get; set; }

        //overloaded operators to compare employees by ID
        public static bool operator ==(Employee<T> a, Employee<T> b)
        {
            return a.Id == b.Id;
        }
        public static bool operator !=(Employee<T> a, Employee<T> b)
        {
            return a.Id != b.Id;
        }


        public int Id { get; set; }

        //Used for the Quit() method
        public bool CurrentlyEmployed { get; set; }
    }
}
