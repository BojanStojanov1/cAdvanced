using System;
namespace Task4.Models;

	public abstract class Employee
	{
    public string Name { get; set; }
    public abstract double CalculateSalary();
    public abstract void DisplayInfo();
}

