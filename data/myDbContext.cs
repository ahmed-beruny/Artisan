using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class myDbContext : IdentityDbContext<IdentityUser>
{
    public myDbContext(DbContextOptions<myDbContext> options) : base(options)
    {
    }
    public DbSet<LoginModel> LoginModel { get; set; }
    public DbSet<RegisterModel> RegisterModel { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}