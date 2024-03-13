
namespace Restourant.Domain.Enities
{
	public class CategoryDishes
	{
		public int Id { get; set; }
		public string NameCategory { get; set; }
		public Dishes Dishes { get; set; }
	}

}
