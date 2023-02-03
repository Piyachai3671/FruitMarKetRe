using ProjectRbRuRe.Data;
using ProjectRbRuRe.Data.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<StoreService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CartStoreService>();
builder.Services.AddScoped<CartProductService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<LoginService>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<OrderItemService>();
builder.Services.AddScoped<ReportService>();
builder.Services.AddScoped<ProvinceService>();
builder.Services.AddScoped<AmphoeService>();
builder.Services.AddScoped<TambolService>();


builder.Services.AddScoped<NotificationService>();
builder.Services.AddDbContext<ApplicationContext>(i => i.UseSqlServer("Server=.\\SQLEXPRESS;Database=ProjectRbRuRePlaceData2;Trusted_Connection=True;Encrypt=true;TrustServerCertificate=true; "));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
