using PFM.Database.Entities;
using PFM.Models;

namespace PFM.Database.Repositories
{
    public interface ICategoryRepository
    {
        Task<CategoryEntity> CreateCategory(CategoryEntity newCategoryEntity);
        Task<CategoryEntity> GetCategoryByCode(string categoryCode);
        Task<CategoryList<CategoryEntity>> GetGategories(string parentId);
        Task<CategoryEntity> UpdateCategory(CategoryEntity existingCategory);
        Task<List<CategoryEntity>> GetAllCategories();
    }
}