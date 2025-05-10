using Task2.Interface;
using Task2.Models;

IShape rectangle = new Rectangle(4, 5);
IShape circle = new Circle(3);
IShape triangle = new Triangle(4, 3);
Console.WriteLine(rectangle.GetArea());
Console.WriteLine(circle.GetArea());
Console.WriteLine(triangle.GetArea());

Console.ReadLine();
