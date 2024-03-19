using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;


namespace Restourant.DataAccess.Postgres.Configurations
{
	internal class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
	{
		public void Configure(EntityTypeBuilder<Delivery> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Date).IsRequired();

			builder
				.HasOne(d => d.Provider)
				.WithMany(p => p.Deliveries)
				.HasForeignKey(d => d.ProviderId)
				.HasPrincipalKey(p => p.Id);

			builder
				.HasOne(d => d.Invoice)
				.WithOne(i => i.Delivery);
		}
	}
}
