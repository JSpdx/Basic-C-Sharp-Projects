using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstractExercise
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            CurrentlyEmployed = false;
        }

        //overloaded operators to compare employees by ID
        public static bool operator ==(Employee a, Employee b)
        {
            return a.Id == b.Id;
        }
        public static bool operator !=(Employee a, Employee b)
        {
            return a.Id != b.Id;
        }


        public int Id { get; set; }

        //Used for the Quit() method
        public bool CurrentlyEmployed { get; set; }

    }
}
