
namespace Restourant.Domain.Enities
{
	public class Loyalty
	{
		public int Id { get; set; }
		public int Discount { get; set; }

		public Client Client { get; set; }
	}
}
