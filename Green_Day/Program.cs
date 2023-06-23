using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Green_Day.Data;
using Microsoft.AspNetCore.Identity;
using Green_Day.Models;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<Green_DayContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("Green_DayContext") ?? 
    throw new InvalidOperationException("Connection string 'Green_DayContext' not found.")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<Green_DayContext>()
    .AddDefaultTokenProviders();


//builder.Services.AddDefaultIdentity<IdentityUsers>(options => options.SignIn.RequireConfirmedAccount = true)
    //.AddEntityFrameworkStores<Green_DayContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
