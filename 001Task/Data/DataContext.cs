using Microsoft.EntityFrameworkCore;

namespace _001Task.Data;

public class DataContext : DbContext
{
    
    
    public DbSet<People> Peoples { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    
    public DataContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = @"server=localhost;
                                port=5432;          
                                database=exam122_db;
                                user id=postgres; 
                                password=sabriddin2004";
        optionsBuilder.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasData(DataProvider.Countries);
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<City>().HasData(DataProvider.Cities);
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<People>().HasData(DataProvider.Peoples);
        base.OnModelCreating(modelBuilder);
    }

}
