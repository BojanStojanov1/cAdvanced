using System;
namespace Task1.Models
{
	public static class UserDataBase
	{
        public static List<User> Users = new List<User>
        {
            new User { Id = 1, Name = "Bojan", Age = 25 },
            new User { Id = 2, Name = "Boban", Age = 30 },
            new User { Id = 3, Name = "Vlatko", Age = 25 },
            new User { Id = 4, Name = "David", Age = 35 }
        };
        public static User SearchById(int id)
        {
            return Users.FirstOrDefault(u => u.Id == id);
        }

        public static List<User> SearchByName(string name)
        {
            return Users
                .Where(u => u.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public static List<User> SearchByAge(int age)
        {
            return Users.Where(u => u.Age == age).ToList();
        }
    }
}

