using System;
namespace interfaceHomework.AbstractClassesAndInterfaces.doamin
{
	public abstract class Employee
	{
        public string Name { get; set; }
        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}

