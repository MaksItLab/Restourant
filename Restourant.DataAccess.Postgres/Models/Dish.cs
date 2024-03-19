﻿using System;
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
		/// Список чеков
		/// </summary>
		public List<Check> Checks { get; set;}
		/// <summary>
		/// Категория блюда
		/// </summary>
		public CategoryDish CategoryDish { get; set; }
		/// <summary>
		/// Идентификатор категории блюда
		/// </summary>
		public int CategoryDishId { get; set; }

	}
}
