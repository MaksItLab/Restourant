
namespace Restourant.Domain.Enities
{
	public class Orders
	{
		public int Id { get; set; }

		public int WaiterId { get; set; }
		public Employees Employee { get; set; }
		public Client Client { get; set; }
		public ListOfOrders ListOfOrders { get; set; }
		public int ClientId { get; set; }
		public double Price { get; set; }
		//public DateTime Date { get; set; }
		public string Date { get; set; }
	}
}
