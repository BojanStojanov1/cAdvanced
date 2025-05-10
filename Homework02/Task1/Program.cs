using Task1.Models;

Console.WriteLine("Search by ID 2:");
var userById = UserDataBase.SearchById(2);
Console.WriteLine(userById);

Console.WriteLine("\nSearch by Name 'a':");
var usersByName = UserDataBase.SearchByName("a");
usersByName.ForEach(Console.WriteLine);

Console.WriteLine("\nSearch by Age 25:");
var usersByAge = UserDataBase.SearchByAge(25);
usersByAge.ForEach(Console.WriteLine);

Console.ReadLine();