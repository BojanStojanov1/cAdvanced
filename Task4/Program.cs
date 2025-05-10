using Task4.Models;

Employee manager = new Manager("Bojan", 5000);
Employee programmer = new Programmer("Vlatko", 50, 160);
manager.DisplayInfo();
programmer.DisplayInfo();

Console.ReadLine();

