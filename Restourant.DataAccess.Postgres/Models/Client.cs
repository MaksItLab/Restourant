using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Клиент
	/// </summary>
	public class Client
	{
		/// <summary>
		/// Идентификатор 
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Инициалы
		/// </summary>
		public string FIO { get; set; }
		/// <summary>
		/// Список заказов
		/// </summary>
		public ICollection<Order> Orders { get; set; }
	}
}
