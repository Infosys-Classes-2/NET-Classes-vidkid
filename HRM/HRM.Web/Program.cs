using HRM.Web.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EmployeeContext>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
options.SignIn.RequireConfirmedAccount = false)
.AddEntityFrameworkStores<EmployeeContext>();

builder.Services.AddRazorPages();
var app = builder.Build();

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
