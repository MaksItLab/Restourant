using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Чек
	/// </summary>
	public class Check
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Идентификатор Заказа
		/// </summary>
		public int OrderId { get; set; }
		/// <summary>
		/// Идентификатор блюда
		/// </summary>
		public int DishId { get; set; }
	}
}
