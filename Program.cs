using System;

namespace PracAss2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name; //Name of employee
            double salary; // Yearly salary of employee
            double incPerc; // Increase percentage of the yearly salary
            char answer;

            do
            {
                Console.WriteLine();
                
                // Prompt and read for employee name
                Console.Write("Enter Employee Name: ");
                name = Console.ReadLine();

                // Prompt and read for employee's salary
                Console.Write("Enter Their Yearly salary: ");
                salary = Convert.ToDouble(Console.ReadLine());

                // Prompt and read percentage increase of the yearly salary
                Console.Write("Enter Percentage Increase(like 7,5): ");
                incPerc = Convert.ToDouble(Console.ReadLine());

                //Display employee details
                Console.WriteLine("\nEmployee Details\n" +
                    "-------------------------\n" +
                    $"Employee Name: {name}\n" +
                    $"Old Yearly Salary: R{salary}\n" +
                    $"Old Monthly Salary: R{salary / 12}\n" +
                    $"Increase Percentage: {incPerc}%\n" +
                    $"New Yearly Salary: R{salary * (1 + incPerc / 100)}\n" +
                    $"New Monthly Salaty: R{(salary / 12) * (1 + incPerc / 100)}");

                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("----------------------------------------------------");
                Console.Write("Repeat task(y for yes)");
                answer = Convert.ToChar(Console.ReadLine());
            } while (answer == 'y' || answer == 'Y');
        }
    }
}
