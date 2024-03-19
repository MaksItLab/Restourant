
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
		public Employee Employee { get; set; }
		/// <summary>
		/// Идентификатор сотрудника
		/// </summary>
		public int EmployeeId { get; set; }
		/// <summary>
		/// Список чеков
		/// </summary>
		public ICollection<Check> Checks { get; set; }
	

	}
}
