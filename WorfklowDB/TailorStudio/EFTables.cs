

using System;
using System.Data.Entity;

namespace TailorStudio
{
    class EFTables
    {
		enum Stages { New, OnHold, Processed,Rejected, ToPay,Paid, Cut, Production, Ready}

		static void Main(string[] args)
        {
			Console.Write("Введите логин:");
			string inputLogin = Console.ReadLine();
			Console.Write("Введите пароль: ");
			string inputPassword = Console.ReadLine();
			bool AcsessGranted = false;


			using (TailorContext TailorContext = new TailorContext())
            {
				var users = TailorContext.Users;
				foreach (Users acc in users)
				{
					if ((acc.Login == inputLogin) && (acc.Password == inputPassword))
					{
						AcsessGranted = true;
					}
						
					//Console.WriteLine("{0},{1},{2},{3}",acc.Login, acc.Name, acc.Password,acc.Role);
				}
			}

			if (AcsessGranted)
				Console.WriteLine("Успешная авторизация");
			else
				Console.WriteLine("Неверный логин или пароль");


			/*using (TailorContext TailorContext = new TailorContext())
			{
				TailorContext.Products.Add(new Products (1,"шелк", 2, 5,"",""));
				TailorContext.Users.Add(new Users("Polzovatel", "11111", 1, "Sebastian"));
				TailorContext.Orders.Add(new Orders(1, Convert.ToDateTime("2020-05-17 17:08:23"), 1, "Ivanov","Petrov",1000));
				TailorContext.SaveChanges();
				Console.WriteLine("Объекты успешно сохранены");
				Console.ReadKey();
			}*/
						
		}
    }
	    
}

