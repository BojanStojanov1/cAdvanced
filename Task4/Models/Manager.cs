using System;
using Task4.Models;

namespace Task4.Models
{
	public class Manager : Employee
	{
        public double MonthlySalary { get; set; }

        public Manager(string name, double salary)
        {
            Name = name;
            MonthlySalary = salary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name}, Salary: {CalculateSalary()}");
        }
    }
}

