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

    public DbSet<User>? Users { get; set; }
}