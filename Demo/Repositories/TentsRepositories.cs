using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Repositories
{
	public class TentsRepositories
	{
		private DemoDbContext context;
		public TentsRepositories()
		{
			context = new DemoDbContext(new DbContextOptions<DemoDbContext>());
		}

		public async Task<List<Tent>> GetTents()
		{
			return await context.Tents.ToListAsync();
		}

		public async Task<List<Tent>> GetTent(string brand)
		{
			return await context.Tents.Where(t => t.BrandName == brand).ToListAsync();
		}

		public async Task Create(Tent tent)
		{
			context.Tents.Add(tent);
			await context.SaveChangesAsync();
		}
	}
}
