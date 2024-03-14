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

			//builder
			//	.HasMany(c => c.Orders)
			//	.WithOne(o => o.Check)
			//	.HasForeignKey(o => o.CheckId)
			//	.HasPrincipalKey(c => c.Id);

			//builder
			//	.HasMany(c => c.Dishes)
			//	.WithOne(d => d.Check)
			//	.HasForeignKey(c => c.CheckId)
			//	.HasPrincipalKey (d => d.Id);

		}
	}
}
