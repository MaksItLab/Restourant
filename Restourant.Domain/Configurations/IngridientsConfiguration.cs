using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.Domain.Enities;



namespace Restourant.Domain.Configurations
{
	public class IngridientsConfiguration : IEntityTypeConfiguration<Ingridients>
	{

		public void Configure(EntityTypeBuilder<Ingridients> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(i => i.Dishes)
				.WithMany(d => d.Ingridients)
				.HasForeignKey(i => i.Id);



		}
	}

}
