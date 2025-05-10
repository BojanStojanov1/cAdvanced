using System;
using interfaceHomework.AbstractClassesAndInterfaces.doamin;

namespace interfaceHomework.Models
{
	public class CircleShape : AbstractShape
	{
        public double Radius { get; set; }

        public CircleShape(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}

