using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using E2E_App_Demo.Data;
using System.Diagnostics.CodeAnalysis;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext")));

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<E2E_App_DemoContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("E2E_App_DemoContext") ?? throw new InvalidOperationException("Connection string 'E2E_App_DemoContext' not found.")));

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

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

public partial class Program
{
	/// <summary>
	/// FIXME: This is required for EF Core 6.0 as it is not compatible with trimming.
	/// </summary>
	[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
	private static Type _keepDateOnly = typeof(DateOnly);
}