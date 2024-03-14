using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Поставщик
	/// </summary>
	public class Provider
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
		/// Список поставок
		/// </summary>
		public List<Delivery> Deliveries { get; set; }
	}
}
