using InternshipProject.Areas.Identity.Data;
using InternshipProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class InternshipProjectDBContext : IdentityDbContext<ApplicationUser>
{
    public InternshipProjectDBContext(DbContextOptions<InternshipProjectDBContext> options)
        : base(options)
    {
    }

    // Define your entity sets and additional DbContext configuration here



protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
   
     public  DbSet<Hospital> Hospitalss { get; set; }
    public DbSet<ApplicationUser> ApplicationUser { get; set; }

}

