using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres.Configurations
{
	internal class CategoryDishConfiguration : IEntityTypeConfiguration<CategoryDish>
	{
		public void Configure(EntityTypeBuilder<CategoryDish> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).IsRequired();

			builder
				.HasMany(c => c.Dishes)
				.WithOne(d => d.CategoryDish)
				.HasForeignKey(d => d.CategoryDishId)
				.HasPrincipalKey(c => c.Id);
		}
	}
}
