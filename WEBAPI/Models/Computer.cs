namespace WEBAPI.Models
{
	public class Computer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Year { get; set; }

		public DateTime CreatedAt { get; set; }

	}
}
