using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres.Configurations
{
	public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
	{
		public void Configure(EntityTypeBuilder<Provider> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.FIO).IsRequired();

			builder
				.HasMany(p => p.Deliveries)
				.WithOne(d => d.Provider)
				.HasForeignKey(d => d.ProviderId)
				.HasPrincipalKey(p => p.Id);

		}
	}
}
