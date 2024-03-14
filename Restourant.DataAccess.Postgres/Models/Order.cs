
namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Заказ
	/// </summary>
	public class Order
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Сумма заказа
		/// </summary>
		public double Price { get; set; }
		/// <summary>
		/// Дата заказа
		/// </summary>
		public string Date { get; set; }
		/// <summary>
		/// Клиент
		/// </summary>
		public Client Client { get; set; }
		/// <summary>
		/// Идентификатор клиента
		/// </summary>
		public int ClientId { get; set; }
		/// <summary>
		/// Чек
		/// </summary>
		public Check Check { get; set; }
		/// <summary>
		/// Идентификатор чека
		/// </summary>
		public int CheckId { get; set; }
		/// <summary>
		/// Сотрудник
		/// </summary>
		public Employee Employee { get; set; }
		/// <summary>
		/// Идентификатор сотрудника
		/// </summary>
		public int EmployeeId { get; set; }

	}
}
