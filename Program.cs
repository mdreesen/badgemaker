using System;
using System.Collections.Generic;

namespace Catworx.badgeMaker
{
    class Program
    {
        // This list also refers to the "GetEmployees" method
        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                // Create a new employee instance
                Employee currentEmployee = new Employee(input);
                employees.Add(input);
            }
            return employees;
        }
        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
        static void Main(string[] args)
        {
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}
