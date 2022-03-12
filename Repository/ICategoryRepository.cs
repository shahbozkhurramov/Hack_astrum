using CSA.Entities;

namespace CSA.Repository;

public interface ICategoryRepository
{
    Task<(bool IsSuccess, Exception Exception, Category createdObject)> CreateAsync(Category createdObject);
    Task<List<Category>> GetAllAsync();
    Task<Category> GetAsync(Guid id);
    Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id);
    Task<bool> ExistsAsync(Guid id);
    Task<(bool IsSuccess, Exception Exception, Category updatedObject)> UpdateAsync(Category updatedObject);
}