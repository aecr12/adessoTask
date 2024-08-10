using adessoTaskApi.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System.Xml;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Veritabanı tabloları için DbSet'leri ekleyin
    public DbSet<Country> Countries { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<GeneratorPerson> GeneratorPersons { get; set; }
}

