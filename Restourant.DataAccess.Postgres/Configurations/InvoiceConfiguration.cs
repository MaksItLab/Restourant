using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;


namespace Restourant.DataAccess.Postgres.Configurations
{
	public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
	{
		public void Configure(EntityTypeBuilder<Invoice> builder)
		{
			builder.HasKey(x => x.Id);

			builder
				.HasOne(x => x.Delivery)
				.WithOne(x => x.Invoice);

			builder
				.HasMany(x => x.Products)
				.WithOne(x => x.Invoice)
				.HasForeignKey(x => x.InvoiceId)
				.HasPrincipalKey(x => x.Id);
				
		}
	}
}
