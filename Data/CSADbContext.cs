using CSA.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSA.Data;

public class CSADbContext: DbContext
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<CategoryItem> CategoryItems { get; set; }
    
    public DbSet<Service> Services { get; set; }
    
    public CSADbContext(DbContextOptions<CSADbContext> options)
        : base(options) { }
}