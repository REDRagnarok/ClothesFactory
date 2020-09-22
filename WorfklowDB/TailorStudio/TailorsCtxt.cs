namespace TailorStudio
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TailorContext : DbContext
    {
        public TailorContext()
            : base("name=TailorContext")
        {
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TailorContext>());
		}

        //public virtual DbSet<OrderedProducts> OrderedProducts { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
		public virtual DbSet<Users> Users { get; set; }

		/*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>()
                .Property(e => e.ordStage)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.customer)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.manager)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.pName)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.pComment)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.OrderedProducts)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);
        }*/
	}
}
