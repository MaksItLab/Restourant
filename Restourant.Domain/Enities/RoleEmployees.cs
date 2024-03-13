
namespace Restourant.Domain.Enities
{
	public class RoleEmployees
	{
		public int Id { get; set; }
		public string NameRole { get; set; }
		public Employees Employee { get; set; }
	}
}
