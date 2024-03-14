using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Ингридинет
	/// </summary>
	public class Ingridient
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Блюдо
		/// </summary>
		public Dish Dish { get; set; }
		/// <summary>
		/// Идентификатор блюдо
		/// </summary>
		public int DishId { get; set; }

	}
}
