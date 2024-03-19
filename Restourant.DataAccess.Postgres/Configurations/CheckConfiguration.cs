using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres.Configurations
{
	public class CheckConfiguration : IEntityTypeConfiguration<Check>
	{
		public void Configure(EntityTypeBuilder<Check> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(c => c.Dish)
				.WithMany(d => d.Checks)
				.HasForeignKey(c => c.DishId)
				.HasPrincipalKey(d => d.Id);

			builder
				.HasOne(c => c.Order)
				.WithMany(o => o.Checks)
				.HasForeignKey(c => c.OrderId)
				.HasPrincipalKey(o => o.Id);

		}
	}
}
