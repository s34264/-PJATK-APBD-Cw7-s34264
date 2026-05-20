using Microsoft.EntityFrameworkCore;
namespace PJATK_APBD_Cw7_s34264.Models;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Component> Components { get; set; }
    public DbSet<ComponentType> ComponentTypes { get; set; }
    public DbSet<PCComponent> PCComponents { get; set; }
    public DbSet<PC> PCs { get; set; }
    public DbSet<ComponentManufacturer> ComponentManufacturers { get; set; }
}