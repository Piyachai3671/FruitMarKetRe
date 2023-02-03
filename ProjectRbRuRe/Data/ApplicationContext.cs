using ProjectRbRuRe.Data.ModelData;
using Microsoft.EntityFrameworkCore;
using ProjectRbRuRe.Data.ModelData;

namespace ProjectRbRuRe.Data
{
	public class ApplicationContext : DbContext

	{
		public ApplicationContext(
			DbContextOptions<ApplicationContext> options) : base(options)
		{ }

		public DbSet<TableUser> TableUser { get; set; }
		public DbSet<TableProduct> TableProduct { get; set; }

		public DbSet<TableCartStore> TableCartStore { get; set; }
		public DbSet<TableCartProduct> TableCartProduct { get; set; }

		public DbSet<TableOrder> TableOrder { get; set; }
		public DbSet<TableOrderItem> TableOrderItem { get; set; }
		public DbSet<TableReport> TableReport { get; set; }


		public DbSet<TableStore> TableStore { get; set; }

		public DbSet<TableProvince> TableProvince { get; set; }
		public DbSet<TableAmphoe> TableAmphoe { get; set; }
		public DbSet<Tabletambol> Tabletambol { get; set; }
	}
}
