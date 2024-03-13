using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.Domain.Enities;



namespace Restourant.Domain.Configurations
{
	public class DishesConfiguration : IEntityTypeConfiguration<Dishes>
	{

		public void Configure(EntityTypeBuilder<Dishes> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(d => d.ListOfOrder)
				.WithMany(l => l.Dishes)
				.HasForeignKey(d => d.Id);

			builder
				.HasMany(d => d.Category)
				.WithOne(c => c.Dishes)
				.HasForeignKey(c => c.Id);

			builder
				.HasMany(d => d.Ingridients)
				.WithOne(c => c.Dishes)
				.HasForeignKey(c => c.Id);

		}
	}


}
