using Microsoft.EntityFrameworkCore;
using PONTO.DAO;
using System.Text.Json.Serialization;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// DB
var conn = builder.Environment.IsDevelopment() ? builder.Configuration.GetConnectionString("DefaultConnection") : builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<appDbContext>(opt => opt.UseMySql(conn, ServerVersion.AutoDetect(conn)), ServiceLifetime.Scoped);
// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(c => c.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddControllers();


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
