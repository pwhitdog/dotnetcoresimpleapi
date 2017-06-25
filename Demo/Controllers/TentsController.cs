using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Models;
using Demo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
	[Produces("application/json")]
	[Route("api/Tents")]
	public class TentsController : Controller
	{
		private TentsRepositories repository;
		public TentsController()
		{
			repository = new TentsRepositories();
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok(await repository.GetTents());
		}

		[HttpGet("{brandName}")]
		public async Task<IActionResult> Get(string brandName)
		{
			return Ok(await repository.GetTent(brandName));
		}
	}
}