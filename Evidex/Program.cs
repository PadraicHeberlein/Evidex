using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Evidex.Data;
using Npgsql;
using Evidex.Utilities.Logs;

var builder = WebApplication.CreateBuilder(args);

string evidexConnect =
    "User ID=evidex;Password=ALthEA25lad!$;Server= " + 
    "host.docker.internal;Port=5433;Database=evidex;" +
    "Integrated Security=true;Pooling=true";

NpgsqlConnectionStringBuilder postgresBuilder
    = new NpgsqlConnectionStringBuilder(evidexConnect);

// Add services to the container.
builder.Services.AddDbContext<EvidexContext>(options =>
    options.UseNpgsql(postgresBuilder.ConnectionString));
builder.Services.AddControllersWithViews();

var app = builder.Build();
        
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

app.Run();
