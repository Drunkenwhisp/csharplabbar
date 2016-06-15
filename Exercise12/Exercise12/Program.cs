using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Firstname?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your birth day??");

            DateTime userBD = new DateTime();
            DateTime now = DateTime.Now;
            while (!DateTime.TryParse(Console.ReadLine(), out userBD))
                Console.WriteLine("You did not write a correct DateTime, please try again");

            var timespan = now - userBD;
            int wholeyears = timespan.Days / 365;
            int hundred = 99 - (now.Year - userBD.Year);
            var WhenHundred = new DateTime((now.Year + hundred), userBD.Month, userBD.Day);

            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"You are {wholeyears} years and {timespan.Days % 365} days old");
            Console.WriteLine($"Your next birthday is in {365 -(timespan.Days % 365)} days");
            Console.WriteLine($"You will turn 100 years old on a {WhenHundred.DayOfWeek}");


        }
    }
}
