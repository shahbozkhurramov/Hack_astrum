using CSA.Data;
using CSA.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSA.Repository;

public class CategoryItemRepository : ICategoryItemRepository
{
    private readonly ILogger<CategoryItemRepository> _logger;
    private readonly CSADbContext _context;

    public CategoryItemRepository(CSADbContext context, ILogger<CategoryItemRepository> logger)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<(bool IsSuccess, Exception Exception, CategoryItem createdObject)> CreateAsync(CategoryItem createdObject)
    {
        try
        {
            await _context.CategoryItems.AddAsync(createdObject);
            await _context.SaveChangesAsync();

            return (true, null, createdObject);
        }
        catch(Exception e)
        {
            return (false, e, null);
        }
    }

    public async Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id)
    {
        try
        {
            var categoryItem = await _context.CategoryItems.FirstOrDefaultAsync(c => c.Id == id);
            _context.CategoryItems.Remove(categoryItem);
            await _context.SaveChangesAsync();

            return (true, null);
        }
        catch(Exception e)
        {
            return (false, e);
        }
    }

    public Task<bool> ExistsAsync(Guid id)
        => _context.Categories.AnyAsync(c => c.Id==id);

    public Task<List<CategoryItem>> GetAllAsync()
        => _context.CategoryItems
            .AsNoTracking()
            .Include(c => c.Services)
            .ToListAsync();

    public Task<CategoryItem> GetAsync(Guid id)
        => _context.CategoryItems.FirstOrDefaultAsync(c => c.Id == id);

    public async Task<(bool IsSuccess, Exception Exception, CategoryItem updatedObject)> UpdateAsync(CategoryItem updatedObject)
    {
         try
        {
            _context.CategoryItems.Update(updatedObject);
            await _context.SaveChangesAsync();

            return (true, null, updatedObject);
        }
        catch(Exception e)
        {
            return (false, e, updatedObject);
        }
    }
}