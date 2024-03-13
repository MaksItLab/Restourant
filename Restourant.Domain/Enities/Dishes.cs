
namespace Restourant.Domain.Enities
{
	public class Dishes
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ICollection<CategoryDishes> CategoryDishes { get; set; }
		public ICollection<Ingridients> Ingridients { get; set; }
		public ListOfOrders ListOfOrder { get; set; }
		//public int CategiryId { get; set; }
		public string Recipe {  get; set; }
	}
}
