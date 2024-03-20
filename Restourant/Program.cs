using Microsoft.EntityFrameworkCore;
using Restourant.DataAccess.Postgres;
using Restourant.Services;
using Restourant.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<RestourantDbContext>(options =>
{
	options.UseNpgsql("User ID=postgres;Password=root;Host=localhost;Port=5432;Database=Restourant;Pooling=true;");
});

//builder.Services.AddScoped<IRestourantData, RestourantData>();

var app = builder.Build();

app.MapGet("/api/employees", async (RestourantDbContext restourantDbContext) =>
{
	var employees = await restourantDbContext.Employees
		.Include(x => x.Role)
		.Select(x => new
		{
			x.Id,
			x.FIO,
			RoleName = x.Role.Name,
		}).ToListAsync();

	return (employees);
});

app.MapGet("/api/client", async (RestourantDbContext restourantDbContext) =>
{
	var clients = await restourantDbContext.Clients
		.Select(x => new
		{
			x.Id,
			x.FIO,
		}).ToListAsync();

	return (clients);
});

app.MapGet("/api/categorydish", async (RestourantDbContext restourantDbContext) =>
{
	var category = await restourantDbContext.CategoryDishes
		.Select(x => new
		{
			x.Id,
			x.Name,
		}).ToListAsync();

	return (category);
});

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseAuthorization();

app.Run();
