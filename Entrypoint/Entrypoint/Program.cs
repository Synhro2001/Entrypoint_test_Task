using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Entrypoint.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EntrypointContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EntrypointContext") ?? throw new InvalidOperationException("Connection string 'EntrypointContext' not found.")));

// Add services to the container.
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
    pattern: "{controller=Clients}/{action=Index}/{id?}");

app.Run();
