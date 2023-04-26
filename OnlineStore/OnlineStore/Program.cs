using Microsoft.EntityFrameworkCore;
using OnlineStore.BussinessLayer.Services.Implementations;
using OnlineStore.BussinessLayer.Services.Interfaces;
using OnlineStore.DataAccessLayer.Repository.Implementations;
using OnlineStore.DataAccessLayer.Repository.Interfaces;
using OnlineStore_Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddScoped<ICatalogService, CatalogService>();
builder.Services.AddScoped<ICatalogRepository, CatalogRepository>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<StoreDbConn>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}
app.UseCors(builder => builder
       .AllowAnyHeader()
       .AllowAnyMethod()
       .AllowAnyOrigin()
    );

//app.UseStaticFiles();
//app.UseRouting();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller}/{action=Index}/{id?}");
app.UseHttpsRedirection();
app.MapControllers();
app.MapFallbackToFile("index.html"); ;

app.Run();
