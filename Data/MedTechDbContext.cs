using MedTech.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedTech.Data;

public class MedTechDbContext: DbContext
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<CategoryItem> CategoryItems { get; set; }
    
    public DbSet<Service> Services { get; set; }
    
    public MedTechDbContext(DbContextOptions<MedTechDbContext> options)
        : base(options) { }
}