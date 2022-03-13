using CSA.Entities;

namespace CSA.Repository;

public interface IServiceRepository
{
    Task<(bool IsSuccess, Exception Exception, Service createdObject)> CreateAsync(Service createdObject);
    Task<List<Service>> GetAllAsync();
    Task<Service> GetAsync(Guid id);
    Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id);
    Task<bool> ExistsAsync(Guid id);
    Task<(bool IsSuccess, Exception Exception, Service updatedObject)> UpdateAsync(Service updatedObject);
}