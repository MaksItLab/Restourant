using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;


namespace Restourant.DataAccess.Postgres.Configurations
{
	public class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Price).IsRequired();
			builder.Property(x => x.ClientId).IsRequired();

			builder
				.HasOne(o => o.Client)
				.WithMany(c => c.Orders)
				.HasForeignKey(o => o.ClientId)
				.HasPrincipalKey(c => c.Id);

			builder
				.HasMany(o => o.Checks)
				.WithOne(c => c.Order)
				.HasForeignKey(c => c.OrderId)
				.HasPrincipalKey(o => o.Id);

			builder
				.HasOne(o => o.Employee)
				.WithMany(e => e.Orders)
				.HasForeignKey(o => o.EmployeeId)
				.HasPrincipalKey(e => e.Id);
		}
	}
}
