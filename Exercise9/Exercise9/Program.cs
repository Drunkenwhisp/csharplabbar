using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            var employees = new List<Employee>();
            var logger = new Logger();
            do
            {
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Remove employee");
                Console.WriteLine("3. Print entire registry");
                Console.WriteLine("4. Exit");

                int choice = 0;

                while (!int.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("You didn't write a number, please try again");

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your employees firstname");
                        var fName = Console.ReadLine();
                        Console.WriteLine("Enter your employees lastname");
                        var lName = Console.ReadLine();
                        Console.WriteLine("Enter your employees SSN");
                        var SSN = Console.ReadLine();
                        Console.WriteLine("Enter your employees hourly wage");
                        var hWage = int.Parse(Console.ReadLine());
                        var employee = new Employee(fName, lName, SSN, hWage);
                        logger.Log($"A new employee with the name {employee.FullName}, SSN: {SSN} and hourly wage {hWage} is added to the employee list");
                        employees.Add(employee);
                        break;
                    case 2:
                        Console.WriteLine("Here are all the employees, listed by SSN, write the Index of the one you wish to remove");
                        for (int i = 0; i < employees.Count; i++)
                        {
                            Console.WriteLine(i + " " + employees[i].SSN);
                        }
                        var index = int.Parse(Console.ReadLine());
                        logger.Log($"Removed a employee with the SSN {employees[index].SSN}");
                        employees.RemoveAt(index);
                        break;
                    case 3:
                        for (int i = 0; i < employees.Count; i++)
                        {
                            Console.WriteLine($"{employees[i].FullName} , {employees[i].SSN} , {employees[i].Wage}");
                        }
                        break;
                    case 4:
                        play = false;
                        break;
                    default:
                        Console.WriteLine("You didn't write a number between 1-4, try again");
                        break;
                }
            } while (play);
        }
    }
}
