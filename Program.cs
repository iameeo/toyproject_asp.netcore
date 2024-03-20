using Microsoft.EntityFrameworkCore;
using ToyProject.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

// DB Context 
builder.Services.AddDbContext<IameeoContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("IameeoDBConn")));

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseStaticFiles();

app.Run();