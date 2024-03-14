using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant.DataAccess.Postgres.Configurations
{
	public class ClientConfiguration : IEntityTypeConfiguration<Client>
	{
		public void Configure(EntityTypeBuilder<Client> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.FIO).IsRequired();

			builder
				.HasMany(c => c.Orders)
				.WithOne(o => o.Client)
				.HasForeignKey(o => o.ClientId)
				.HasPrincipalKey(c => c.Id);
		}
	}
}
