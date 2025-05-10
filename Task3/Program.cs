
using Task3.Models;

AbstractShape circleShape = new CircleShape(3);
AbstractShape triangleShape = new TriangleShape(3, 4, 5);
Console.WriteLine(circleShape.CalculateArea());
Console.WriteLine(circleShape.CalculatePerimeter());
Console.WriteLine(triangleShape.CalculateArea());
Console.WriteLine(triangleShape.CalculatePerimeter());

Console.ReadLine();

