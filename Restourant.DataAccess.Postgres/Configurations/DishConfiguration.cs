using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres.Configurations
{
	public class DishConfiguration : IEntityTypeConfiguration<Dish>
	{
		public void Configure(EntityTypeBuilder<Dish> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).IsRequired();
			builder.Property(x => x.Description);

			builder
				.HasMany(d => d.Ingridients)
				.WithOne(i => i.Dish)
				.HasForeignKey(i => i.DishId)
				.HasPrincipalKey(d => d.Id);

			builder
				.HasMany(d => d.Checks)
				.WithOne(c => c.Dish)
				.HasForeignKey(c => c.DishId)
				.HasPrincipalKey(d => d.Id);

			builder
				.HasOne(d => d.CategoryDish)
				.WithMany(c => c.Dishes)
				.HasForeignKey(d => d.CategoryDishId)
				.HasPrincipalKey(c => c.Id);
		}
	}
}
