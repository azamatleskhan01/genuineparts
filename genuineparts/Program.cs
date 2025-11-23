using Microsoft.EntityFrameworkCore;
using genuineparts.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Подключение DbContext к PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Подключаем контроллеры с Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Настройка маршрута по умолчанию
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=page}/{id?}");
            
app.Run();