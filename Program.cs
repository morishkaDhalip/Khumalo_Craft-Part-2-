using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Khumalo_Craft.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Khumalo_CraftContext>(options =>
    options.UseSqlServer( "Data Source=labVMH8OX\\SQLEXPRESS;Initial Catalog=Khumalo_craft;Integrated Security=True;Trust Server Certificate=True" ?? throw new InvalidOperationException("Connection string 'Khumalo_CraftContext' not found.")));
builder.Services.AddDistributedMemoryCache(); // Required for session storage
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20); // Set session timeout (default is 20 minutes)
    options.Cookie.HttpOnly = true; // Flag to help prevent XSS attacks (recommended)
                                    // Other optional settings (e.g., cookie name, domain)
});

// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    
}
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
