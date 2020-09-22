namespace TailorStudio
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;
	

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

	public partial class Products
	{
		[Required,Key]
		public int Article { get; set; }
		[Required, StringLength(32)]
		public string Name { get; set; }
		[Required]
		public double Width { get; set; }
		[Required]
		public double Length { get; set; }
		public string Picture { get; set; }
		[StringLength(300)]
		public string Comment { get; set; }
		
		public Products() { }
		public Products(int article, string name, double width, double length, string image, string comment)
		{
			article = Article;
			name = Name;
			width = Width;
			length = Length;
			image = Picture;
			comment = Comment;
		}
	}

	public partial class Orders
	{
		[Required, Key]
		public int ordID { get; set; }
		[Required]
		public DateTime ordDate { get; set; }
		[Required]
		public byte Stage { get; set; }
		[Required, StringLength(30)]
		public string Customer { get; set; }
		[StringLength(30)]
		public string Manager { get; set; }
		public double Cost { get; set; }

		public Orders() { }
		public Orders(int ONum, DateTime ODate, byte OStage, string OCustomer, string OManager, double Ocost)
		{
			ONum = ordID;
			ODate = ordDate;
			OStage = Stage;
			OCustomer = Customer;
			OManager = Manager;
			Ocost = Cost;
		}
	}
}