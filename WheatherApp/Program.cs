using Microsoft.EntityFrameworkCore;
using Wheather.Data;
using Wheather.Service;
using Wheather.ServiceContract;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
builder.Services.AddTransient<IWheatherContract, WheatherServicesClass>();

var app = builder.Build();
app.UseStaticFiles();
app.MapControllers();


app.Run();
