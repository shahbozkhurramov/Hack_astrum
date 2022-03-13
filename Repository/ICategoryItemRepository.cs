using CSA.Entities;

namespace CSA.Repository;

public interface ICategoryItemRepository
{
    Task<(bool IsSuccess, Exception Exception, CategoryItem createdObject)> CreateAsync(CategoryItem createdObject);
    Task<List<CategoryItem>> GetAllAsync();
    Task<CategoryItem> GetAsync(Guid id);
    Task<(bool IsSuccess, Exception Exception)> DeleteAsync(Guid id);
    Task<bool> ExistsAsync(Guid id);
    Task<(bool IsSuccess, Exception Exception, CategoryItem updatedObject)> UpdateAsync(CategoryItem updatedObject);
}