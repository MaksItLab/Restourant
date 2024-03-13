using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.Domain.Enities;



namespace Restourant.Domain.Configurations
{
	public class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
	{

		public void Configure(EntityTypeBuilder<Employees> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(e => e.Role)
				.WithOne(r => r.Employee);

			builder
				.HasOne(e => e.Order)
				.WithOne(o => o.Employee);

		}
	}


}
