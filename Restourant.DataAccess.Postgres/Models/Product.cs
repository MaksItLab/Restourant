namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Продукт
	/// </summary>
	public class Product
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
		/// Категория продукта
		/// </summary>
		public CategoryProduct CategoryProduct { get; set; }
		/// <summary>
		/// Идентификатор категории продукта
		/// </summary>
		public int CategoryProductId { get; set; }
		/// <summary>
		/// Склад
		/// </summary>
		public Storage Storage { get; set; }
		/// <summary>
		/// Ингридиент
		/// </summary>
		public Ingridient Ingridient { get; set; }
		/// <summary>
		/// Накладная
		/// </summary>
		public Invoice Invoice { get; set; }
		/// <summary>
		/// Идентификатор накладной
		/// </summary>
		public int InvoiceId { get; set; }
		
	}
}
