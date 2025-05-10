using System;
using interfaceHomework.AbstractClassesAndInterfaces.doamin;

namespace interfaceHomework.Models
{
	public class Programmer : Employee
	{
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Programmer(string name, double hourlyRate, int hoursWorked)
        {
            Name = name;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer: {Name}, Salary: {CalculateSalary()}");
        }
    }
}

