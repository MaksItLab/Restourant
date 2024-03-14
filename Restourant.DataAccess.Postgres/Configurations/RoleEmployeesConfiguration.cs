using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.DataAccess.Postgres.Models;

namespace Restourant.DataAccess.Postgres.Configurations
{
    public class RoleEmployeesConfiguration : IEntityTypeConfiguration<RoleEmployee>
    {
        public void Configure(EntityTypeBuilder<RoleEmployee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();

            builder.HasMany(x => x.Employees)
                .WithOne(x => x.Role)
                .HasForeignKey(x => x.RoleId)
                .HasPrincipalKey(x => x.Id);
        }
    }
}
