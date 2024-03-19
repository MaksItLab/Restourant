namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Категория продукта
	/// </summary>
	public class CategoryProduct
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
		/// Список продуктов
		/// </summary>
		public ICollection<Product> Products { get; set; }
	}
}
