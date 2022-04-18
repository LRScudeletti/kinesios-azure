namespace KinesiOSAzureApi.Helpers;

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
        // Disable cascading delete option
        foreach (var relationship in modelBuilder.Model
                     .GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.NoAction;
        }
    }

    public DbSet<User>? Users { get; set; }
}