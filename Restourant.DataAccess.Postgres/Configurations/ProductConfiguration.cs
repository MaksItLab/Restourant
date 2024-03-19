using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres.Configurations
{
	internal class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).IsRequired();

			builder
				.HasOne(p => p.CategoryProduct)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.CategoryProductId)
				.HasPrincipalKey(c => c.Id);

			builder
				.HasOne(p => p.Storage)
				.WithOne(c => c.Product);

			builder
				.HasOne(p => p.Ingridient)
				.WithOne(i => i.Product);

			builder
				.HasOne(x => x.Invoice)
				.WithMany(x => x.Products)
				.HasForeignKey(x => x.InvoiceId)
				.HasPrincipalKey(x => x.Id);
		}
	}
}
