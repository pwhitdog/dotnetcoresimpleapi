using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
	public class DemoDbContext: DbContext
	{
		public DemoDbContext() { }
		public DemoDbContext(DbContextOptions options): base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			builder.UseSqlServer("Server=docker.sql.local;Database=OutdoorDemo;User ID=outdoor;Password=outdoor;");
			base.OnConfiguring(builder);
		}

		public DbSet<Tent> Tents { get; set; }
		public DbSet<SleepingBag> SleepingBags { get; set; }
		public DbSet<BackPack> BackPacks { get; set; }
	}
}
