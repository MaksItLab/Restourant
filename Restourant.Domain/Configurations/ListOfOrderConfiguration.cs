using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.Domain.Enities;



namespace Restourant.Domain.Configurations
{
	public class ListOfOrderConfiguration : IEntityTypeConfiguration<ListOfOrders>
	{

		public void Configure(EntityTypeBuilder<ListOfOrders> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(l => l.Order)
				.WithOne(o => o.ListOfOrders);

			builder
				.HasMany(l => l.Dishes)
				.WithOne(d => d.ListOfOrder)
				.HasForeignKey(d => d.Id);
				
		}
	}

}
