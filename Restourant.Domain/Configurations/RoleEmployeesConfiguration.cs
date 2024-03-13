using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restourant.Domain.Enities;



namespace Restourant.Domain.Configurations
{
	public class RoleEmployeesConfiguration : IEntityTypeConfiguration<RoleEmployees>
	{
		
		public void Configure(EntityTypeBuilder<RoleEmployees> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(r => r.Employee)
				.WithOne(e => e.Role);
		}
	}

	public class CategoryDishesConfiguration : IEntityTypeConfiguration<CategoryDishes>
	{

		public void Configure(EntityTypeBuilder<CategoryDishes> builder)
		{
			builder.HasKey(c => c.Id);

			builder
				.HasOne(cd => cd.Dishes)
				.WithMany(d => d.CategoryDishes)
				.HasForeignKey(cd => cd.Id);
		}
	}

}
