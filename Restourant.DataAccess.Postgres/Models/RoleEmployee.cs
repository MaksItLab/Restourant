namespace Restourant.DataAccess.Postgres.Models
{
    /// <summary>
    /// Роль сотрудника
    /// </summary>
    public class RoleEmployee
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список сотрудников роли
        /// </summary>
        public List<Employee> Employees { get; set; }
    }
}
