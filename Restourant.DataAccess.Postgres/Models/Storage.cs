
namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Склад
	/// </summary>
	public class Storage
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Цена
		/// </summary>
		public double Price { get; set; }
		/// <summary>
		/// Остаток
		/// </summary>
		public int Remmainder { get; set; }
		/// <summary>
		/// Продукт
		/// </summary>
		public Product Product { get; set; }
		/// <summary>
		/// Идентификатор продукта
		/// </summary>
		public int ProductId { get; set; }
	}
}
