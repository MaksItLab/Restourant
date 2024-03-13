
namespace Restourant.Domain.Enities
{
	public class Employees
	{
		public int Id { get; set; }
		public RoleEmployees Role { get; set; }
		public Orders Order { get; set; }
		public int RoleId { get; set; }
		public string Initials { get; set; }
	}
}
