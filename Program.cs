using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FreshFoodShop.Data;
using FreshFoodShop.Data.EFCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<FreshFoodShopContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("FreshFoodShopContext") ?? throw new InvalidOperationException("Connection string 'FreshFoodShopContext' not found.")));
builder.Services.AddScoped<EfCoreProductRepository>();
builder.Services.AddScoped<EfCoreCustomerRepository>();
builder.Services.AddScoped<EfCoreSupplierRepository>();
builder.Services.AddScoped<EfCoreOrderRepository>();
builder.Services.AddScoped<EfCoreCategoriesRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
