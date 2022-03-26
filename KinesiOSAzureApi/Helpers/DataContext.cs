using KinesiOSAzureApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace KinesiOSAzureApi.Helpers;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("KinesiOSAzureSqlServer") ?? throw new InvalidOperationException());
    }

    public DbSet<User>? Users { get; set; }
}