using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
	// api/Products/Get
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{

		// api/Products
		[HttpGet]
		public string[] Get()
		{
			return ["TV", "PC"];
		}
		// api/Products/{id}
		[HttpGet("{id}")]
		public string GetById(int id)
		{
			return "TV";
		}

		// api/Products/{id}/Categories
		[HttpGet("{id}/Categories")]
		public string[] GetProductCategories(int id)
		{
			return ["Lifestyle", "Home"];
		}
		// api/Products/{id}/Categories/{categoryId}
		[HttpGet("{id}/Categories/{categoryId}")]
		public string[] GetProductCategoriesById(int id, int categoryId)
		{
			return ["Lifestyle", "Home"];
		}
	}
}
