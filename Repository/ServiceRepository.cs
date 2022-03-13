using CSA.Data;
using CSA.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSA.Repository;

public class ServiceRepository : IServiceRepository
{
    private readonly ILogger<ServiceRepository> _logger;
    private readonly CSADbContext _context;

    public ServiceRepository(CSADbContext context, ILogger<ServiceRepository> logger)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<(bool IsSuccess, Exception Exception, Service createdObject)> CreateAsync(Service createdObject)
    {
        try
        {
            await _context.Services.AddAsync(createdObject);
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
            var service = await _context.Services.FirstOrDefaultAsync(c => c.Id == id);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();

            return (true, null);
        }
        catch(Exception e)
        {
            return (false, e);
        }
    }

    public Task<bool> ExistsAsync(Guid id)
        => _context.Services.AnyAsync(c => c.Id==id);

    public Task<List<Service>> GetAllAsync()
        => _context.Services.ToListAsync();

    public Task<Service> GetAsync(Guid id)
        => _context.Services.FirstOrDefaultAsync(c => c.Id == id);

    public async Task<(bool IsSuccess, Exception Exception, Service updatedObject)> UpdateAsync(Service updatedObject)
    {
         try
        {
            _context.Services.Update(updatedObject);
            await _context.SaveChangesAsync();

            return (true, null, updatedObject);
        }
        catch(Exception e)
        {
            return (false, e, updatedObject);
        }
    }
}