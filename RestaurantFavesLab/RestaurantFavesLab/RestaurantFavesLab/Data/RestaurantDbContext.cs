using Microsoft.EntityFrameworkCore;
using RestaurantFavesLab.Models;

namespace RestaurantFavesLab.Data;

public class RestaurantDbContext : DbContext
{
    public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) { }

    public virtual DbSet<Order> Orders { get; set; }
}
