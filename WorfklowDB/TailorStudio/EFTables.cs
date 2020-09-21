

using System;
using System.Data.Entity;

namespace TailorStudio
{
    class EFTables
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                db.Users.Add(new User { Id = 5, Name = "Bill", Age = 56 });
                /*db.Users.Add(new User { Id = 2, Name = "Jennifer", Age = 39 });
                db.Users.Add(new User { Id = 3, Name = "Peter", Age = 14 });
                db.Users.Add(new User { Id = 4, Name = "Zelda", Age = 19 });*/
                //db.Users.Add(new User { Id = 5, Name = "Axel", Age = 23 });
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");
            }
            Console.ReadKey();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext() : base("dbconn")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UserContext>());
        }

    }
}

