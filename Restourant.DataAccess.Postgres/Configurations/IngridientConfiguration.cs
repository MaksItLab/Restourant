using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres.Configurations
{
	public class IngridientConfiguration : IEntityTypeConfiguration<Ingridient>
	{
		public void Configure(EntityTypeBuilder<Ingridient> builder)
		{
			builder.HasKey(x => x.Id);

			builder
				.HasOne(i => i.Dish)
				.WithMany(d => d.Ingridients)
				.HasForeignKey(i => i.DishId)
				.HasPrincipalKey(d => d.Id);

			builder
				.HasOne(i => i.Product)
				.WithOne(p => p.Ingridient);
		}
	}
}
