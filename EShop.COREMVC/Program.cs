using EShop.BLL.AutoMapper;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.BLL.ServiceInjections;
using Microsoft.Extensions.DependencyInjection;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//**************************************

builder.Services.MapperServiceInjections(); //Mapper Services
builder.Services.AddDbContextService();     //Context Services
builder.Services.AddRepServices();          //Repositories Services
builder.Services.AddManagerServices();      //Manager Services



//*************************************
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); //Giriþ için Area !! eriþim

app.UseAuthorization();



app.MapControllerRoute(
     name: "Areas",
     pattern: "{Area}/{Controller=Home}/{Action=Index}/{id?}"

    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=LogIn}/{id?}");

app.Run();
