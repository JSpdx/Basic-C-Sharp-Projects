using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.WriteLine("What course are you on?");
            string studentCourseInput = Console.ReadLine();
            Console.WriteLine("What page number?");
            string studentPageInput = Console.ReadLine();
            short PageNumber = Convert.ToInt16(studentPageInput);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”");
            string studentHelpInput = Console.ReadLine();
            bool needsHelp = Convert.ToBoolean(studentHelpInput);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studentHoursInput = Console.ReadLine();
            float hoursStudied = float.Parse(studentHoursInput);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();



        }
    }
}
