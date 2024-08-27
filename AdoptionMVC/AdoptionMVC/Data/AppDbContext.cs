using Microsoft.EntityFrameworkCore;
using AdoptionMVC.Models;

namespace AdoptionMVC.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    //Add your tables here
    public DbSet<Animal> Animals { get; set; }
}