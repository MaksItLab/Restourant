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
		/// Список заказов
		/// </summary>
		public ICollection<Order> Orders { get; set;}

		/// <summary>
		/// Список блюд
		/// </summary>
		public ICollection<Dish> Dishes { get; set;}
	}
}
