using Generic.domain;

PrintInConsole.Print("Hello, Bojan!");
PrintInConsole.Print(42);
PrintInConsole.Print(3.14);

var names = new List<string> { "Bojan", "Boban", "Vlatko" };
var numbers = new List<int> { 1, 2, 3, 4, 5 };

PrintInConsole.PrintCollection(names);
PrintInConsole.PrintCollection(numbers);

Console.ReadLine();
