using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LoginWindow
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		
		public MainWindow()
		{
			InitializeComponent();
		}
		
		public partial class Users
		{
			[Required]
			[Key]
			[Column(Order = 1)]
			[StringLength(16)]
			public string Login { get; set; }
			[Required, Key, Column(Order = 2), StringLength(32)]
			public string Password { get; set; }
			[Required]
			public byte Role { get; set; }
			[StringLength(50)]
			public string Name { get; set; }

			public Users() { }
			public Users(string login, string password, byte role, string name)
			{
				Login = login;
				Password = password;
				Role = role;
				Name = name;
			}
		}
				

		public partial class TailorContext : DbContext
		{
			public TailorContext()
				: base("name=TailorContext")
			{
			}
			public virtual DbSet<Users> Users { get; set; }
			//public virtual DbSet<OrderedProducts> OrderedProducts { get; set; }
			//public virtual DbSet<Orders> Orders { get; set; }
			//public virtual DbSet<Products> Products { get; set; }
			
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			string inputLogin = LoginBox.Text;
			string inputPassword = PassBox.Text;
			string Granted = "Добро пожаловать!";
			string Rejected = "Неверный логин\\пароль!";

			using (TailorContext TailorContext = new TailorContext())
			{
				var users = TailorContext.Users;
				foreach (Users acc in users)
				{
					if ((acc.Login == inputLogin) && (acc.Password == inputPassword))
					{
						Response.Content = Granted;
					}
					else
						Response.Content = Rejected;

					//Console.WriteLine("{0},{1},{2},{3}",acc.Login, acc.Name, acc.Password,acc.Role);
				}
			}
		}

		private void Cancel_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
