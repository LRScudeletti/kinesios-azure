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

    public DbSet<Application>? Applications { get; set; }
    public DbSet<City>? Cities { get; set; }
    public DbSet<Country>? Countries { get; set; }
    public DbSet<Device>? Devices { get; set; }
    public DbSet<MedicalRecord>? MedicalRecords { get; set; }
    public DbSet<Patient>? Patients { get; set; }
    public DbSet<Session>? Sessions { get; set; }
    public DbSet<Specialist>? Specialist { get; set; }
    public DbSet<State>? States { get; set; }
    public DbSet<User>? Users { get; set; }
}