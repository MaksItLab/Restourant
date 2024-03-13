using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.Domain.Enities;



namespace Restourant.Domain.Configurations
{
	public class LoyaltyConfiguration : IEntityTypeConfiguration<Loyalty>
	{

		public void Configure(EntityTypeBuilder<Loyalty> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(l => l.Client)
				.WithOne(c => c.Loyalty);
		}
	}

}
