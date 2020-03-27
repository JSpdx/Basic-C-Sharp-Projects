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

        public bool CurrentlyEmployed { get; set; }
    }
}
