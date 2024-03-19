
namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Накладная
	/// </summary>
	public class Invoice
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }	
		/// <summary>
		/// Количество
		/// </summary>
		public int Count { get; set; }
		/// <summary>
		/// Название продукта
		/// </summary>
		public string ProductName { get; set; }
		/// <summary>
		/// Поставка
		/// </summary>
		public Delivery Delivery { get; set; }
		/// <summary>
		/// Идентификатор доставки
		/// </summary>
		public int DeliveryId { get; set; }
		/// <summary>
		/// Список продуктов
		/// </summary>
		public List<Product> Products {  get; set; }
		
	}
}
