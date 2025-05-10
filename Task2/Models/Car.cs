using System;
namespace Task2.Models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a car and I drive on 4 wheels :)");
        }

        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}

