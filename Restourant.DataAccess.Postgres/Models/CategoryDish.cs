

namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Категория блюда
	/// </summary>
	public class CategoryDish
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Список блюд
		/// </summary>
		public List<Dish> Dishes { get; set; }
	}
}
