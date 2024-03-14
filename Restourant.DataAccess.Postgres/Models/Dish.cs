using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant.DataAccess.Postgres.Models
{
	/// <summary>
	/// Блюдо
	/// </summary>
	public class Dish
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Название блюда
		/// </summary>
		public string Name { get; set;}
		/// <summary>
		/// Описание блюда
		/// </summary>
		public string Description { get; set;}
		/// <summary>
		/// Рецепт
		/// </summary>
		public string Recipe { get; set;}
		/// <summary>
		/// Список ингридиентов
		/// </summary>
		public List<Ingridient> Ingridients { get; set;}
		/// <summary>
		/// Чек
		/// </summary>
		public Check Check { get; set;}
		/// <summary>
		/// Идентификатор чека
		/// </summary>
		public int CheckId { get; set; }

	}
}
