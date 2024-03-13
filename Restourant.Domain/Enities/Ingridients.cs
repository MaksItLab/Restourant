
namespace Restourant.Domain.Enities
{
	public class Ingridients
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public Dishes Dishes { get; set; }
		public int Count { get; set; }

	}

}
