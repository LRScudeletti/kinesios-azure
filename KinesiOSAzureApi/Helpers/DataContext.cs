using KinesiOSAzureApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KinesiOSAzureApi.Helpers;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("KinesiOSAzureApiSqlServer") ?? throw new InvalidOperationException());
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

    public DbSet<Application>? Application { get; set; }
    public DbSet<City>? City { get; set; }
    public DbSet<Country>? Country { get; set; }
    public DbSet<Device>? Device { get; set; }
    public DbSet<Session>? Session { get; set; }
    public DbSet<State>? State { get; set; }
    public DbSet<User>? User { get; set; }
}