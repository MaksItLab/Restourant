using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres.Configurations
{
	public class StorageConfiguration : IEntityTypeConfiguration<Storage>
	{
		public void Configure(EntityTypeBuilder<Storage> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Price).IsRequired();
			builder.Property(x => x.Remmainder).IsRequired();

			builder
				.HasOne(x => x.Product)
				.WithOne(x => x.Storage);

		}
	}
}
