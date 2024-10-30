using Microsoft.AspNetCore.Mvc;
using WEBAPI.DTOs;
using WEBAPI.Models;


namespace WEBAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ComputersController : ControllerBase
	{
		private static List<Computer> _computer = [];



		// GET: api/<ComputersController>
		[HttpGet]
		public IEnumerable<Computer> Get()
		{
			return _computer;
		}

		// GET api/<ComputersController>/5
		[HttpGet("{id}")]
		public Computer Get(int id)
		{
			return _computer.FirstOrDefault(x => x.Id == id);
		}

		// POST api/<ComputersController>
		[HttpPost]
		public void Post([FromBody] CreateComputerDTO newComputer)
		{
			Computer computer = new Computer()
			{
				Id = newComputer.Id,
				Name = newComputer.Name,
				Description = newComputer.Description,
				Year = newComputer.Year,
				CreatedAt = DateTime.Now,
			};

			_computer.Add(computer);
		}
		// PUT api/<ComputersController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] UpdateComputerDTO newComputer)
		{
			var computer = _computer.FirstOrDefault(x => x.Id == id);
			computer.Name = newComputer.Name;
			computer.Description = newComputer.Description;
			computer.Year = newComputer.Year;
		}

		// DELETE api/<ComputersController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			var computer = _computer.FirstOrDefault(x => x.Id == id);
			_computer.Remove(computer);
		}
	}
}
