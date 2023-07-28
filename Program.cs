using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using InternshipProject.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("InternshipProjectDBContextConnection") ?? throw new InvalidOperationException("Connection string 'InternshipProjectDBContextConnection' not found.");

builder.Services.AddDbContext<InternshipProjectDBContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<ApplicationUser>()
    .AddDefaultTokenProviders().AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<InternshipProjectDBContext>();
//// for identity
//builder.Services.AddIdentity<ApplicationUser,IdentityRole>()
//    .AddEntityFrameworkStores<InternshipProjectDBContext>().AddDefaultTokenProviders();
//builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/Identity/Account/Login");


//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<InternshipProjectDBContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.Configure<IdentityOptions>(options => 
{
    options.Password.RequireUppercase = false;
    //options.Email.RequireUppercase = false;
});




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
//app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.MapRazorPages();

app.Run();
