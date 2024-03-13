using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.Domain.Enities;



namespace Restourant.Domain.Configurations
{
	public class ClientConfiguration : IEntityTypeConfiguration<Client>
	{

		public void Configure(EntityTypeBuilder<Client> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(c => c.Order)
				.WithOne(o => o.Client);

			builder
				.HasOne(c => c.Loyalty)
				.WithOne(l => l.Client);
		}
	}


}
