using EShop.BLL.AutoMapper;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.BLL.ServiceInjections;
using Microsoft.Extensions.DependencyInjection;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//**************************************

builder.Services.MapperServiceInjections();
builder.Services.AddDbContextService();
builder.Services.AddRepServices();
builder.Services.AddManagerServices(); 



//*************************************
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
