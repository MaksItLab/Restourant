
namespace Restourant.Domain.Enities
{
	public class ListOfOrders
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public Orders Order { get; set; }
		public ICollection<Dishes> Dishes { get; set; } = [];
		
	}
}
