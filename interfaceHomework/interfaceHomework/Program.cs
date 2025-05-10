using interfaceHomework.AbstractClassesAndInterfaces.doamin;
using interfaceHomework.Interface;
using interfaceHomework.Models;

ISearchable doc = new Document("Hello world in a document.");
ISearchable web = new WebPage("<html>Hello web page!</html>");
Console.WriteLine(doc.Search("world")); 
Console.WriteLine(web.Search("page"));

IShape rectangle = new Rectangle(4, 5);
IShape circle = new Circle(3);
IShape triangle = new Triangle(4, 3);
Console.WriteLine(rectangle.GetArea());
Console.WriteLine(circle.GetArea());
Console.WriteLine(triangle.GetArea());

AbstractShape circleShape = new CircleShape(3);
AbstractShape triangleShape = new TriangleShape(3, 4, 5);
Console.WriteLine(circleShape.CalculateArea());
Console.WriteLine(circleShape.CalculatePerimeter());
Console.WriteLine(triangleShape.CalculateArea());
Console.WriteLine(triangleShape.CalculatePerimeter());

Employee manager = new Manager("Bojan", 5000);
Employee programmer = new Programmer("Vlatko", 50, 160);
manager.DisplayInfo();
programmer.DisplayInfo();

Console.ReadLine();
