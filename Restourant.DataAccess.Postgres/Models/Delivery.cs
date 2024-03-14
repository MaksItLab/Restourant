
namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Поставка
	/// </summary>
	public class Delivery
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Дата поставки
		/// </summary>
		public string Date { get; set; }
		/// <summary>
		/// Поставщик
		/// </summary>
		public Provider Provider { get; set; }
		/// <summary>
		/// Идентификатор поставщика
		/// </summary>
		public int ProviderId { get; set; }
	}
}
