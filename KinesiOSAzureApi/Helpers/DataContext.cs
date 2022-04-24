namespace KinesiOSAzureApi.Helpers;

using BCrypt.Net;
using Entities;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("KinesiOSAzureApiSqlServer"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //// Default user, must be removed after registration of the first user
        //modelBuilder.Entity<User>()
        //    .HasData(
        //        new User
        //        {
        //            Username = "Admin",
        //            UserPassword = "Admin@123",
        //            Email = "rogerio.scudeletti@gmail.com",
        //            UserPasswordHash = BCrypt.HashPassword("Admin@123"),
        //            UserRole = Role.Admin,
        //            UserStatus = true,
        //            UserUpdate = "Admin",
        //            UserUpdateDate = DateTime.Now
        //        }
        //    );

        // Disable cascading delete option
        foreach (var relationship in modelBuilder.Model
                     .GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.NoAction;
        }
    }

    public DbSet<User>? Users { get; set; }
}