
namespace Restourant.Domain.Enities
{
	public class Client
	{
		public int Id { get; set; }
		public int LoyaltyId { get; set; }
		public string Initials { get; set; }

		public Orders Order { get; set; }
		public Loyalty Loyalty { get; set; }
	}
}
