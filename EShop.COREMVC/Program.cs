using EShop.BLL.AutoMapper;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.BLL.ServiceInjections;
using Microsoft.Extensions.DependencyInjection;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//**************************************
builder.Services.AddIdentityServices();     //Identity Services
builder.Services.MapperServiceInjections(); //Mapper Services
builder.Services.AddDbContextService();     //Context Services
builder.Services.AddRepServices();          //Repositories Services
builder.Services.AddManagerServices();      //Manager Services
builder.Services.AddCookieServices();       //Cookie Services


//*************************************
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); 

app.UseAuthorization();    


app.MapControllerRoute(
    name: "Areas",
    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Shopping}/{action=Index}/{id?}");

app.Run();
