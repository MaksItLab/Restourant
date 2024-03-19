
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres.Configurations
{
	public class CategoryProductConfiguration : IEntityTypeConfiguration<CategoryProduct>
	{
		public void Configure(EntityTypeBuilder<CategoryProduct> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).IsRequired();

			builder
				.HasMany(x => x.Products)
				.WithOne(x => x.CategoryProduct)
				.HasForeignKey(x => x.CategoryProductId)
				.HasPrincipalKey(x => x.Id);

		}
	}
}
