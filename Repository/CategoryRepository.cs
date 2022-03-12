using MedTech.Data;
using MedTech.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedTech.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly ILogger<CategoryRepository> _logger;
    private readonly MedTechDbContext _context;

    public CategoryRepository(MedTechDbContext context, ILogger<CategoryRepository> logger)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<(bool IsSuccess, Exception Exception, Category createdObject)> CreateAsync(Category createdObject)
    {
        try
        {
            await _context.Categories.AddAsync(createdObject);
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
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return (true, null);
        }
        catch(Exception e)
        {
            return (false, e);
        }
    }

    public Task<bool> ExistsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Category>> GetAllAsync()
        => _context.Categories
            .AsNoTracking()
            .Include(c => c.CategoryItems)
            .ToListAsync();

    public Task<Category> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<(bool IsSuccess, Exception Exception, Category updatedObject)> UpdateAsync(Category updatedObject)
    {
        throw new NotImplementedException();
    }
}