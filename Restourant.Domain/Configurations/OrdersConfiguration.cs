using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.Domain.Enities;



namespace Restourant.Domain.Configurations
{
	public class OrdersConfiguration : IEntityTypeConfiguration<Orders>
	{

		public void Configure(EntityTypeBuilder<Orders> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(o => o.Client)
				.WithOne(c => c.Order);

			builder
				.HasOne(o => o.Employee)
				.WithOne(e => e.Order);

			builder
				.HasOne(o => o.ListOfOrders)
				.WithOne(l => l.Order);
		}
	}

}
