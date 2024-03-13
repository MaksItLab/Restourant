
namespace Restourant.Domain.Enities
{
	public class Category
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		
		public Product Products { get; set; }
		public List<Product> LProducts { get; set; }
		public int ProductId { get; set; }
	}

}
