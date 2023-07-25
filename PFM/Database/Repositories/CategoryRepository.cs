using Microsoft.EntityFrameworkCore;
using PFM.Database.Entities;
using PFM.Models;

namespace PFM.Database.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        PfmDbContext _dbContext;

        public CategoryRepository(PfmDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CategoryEntity> UpdateCategory(CategoryEntity existingCategory)
        {
            _dbContext.Categories.Update(existingCategory);
            await _dbContext.SaveChangesAsync();
            return existingCategory;
        }

        public async Task<CategoryEntity> CreateCategory(CategoryEntity newCategoryEntity)
        {
            _dbContext.Categories.Add(newCategoryEntity);
            await _dbContext.SaveChangesAsync();
            return newCategoryEntity;
        }


        public async Task<CategoryEntity> GetCategoryByCode(string categoryCode)
        {            
            return await _dbContext.Categories.FirstOrDefaultAsync(x => x.Code.Equals(categoryCode));
        }

        public async Task<List<CategoryEntity>> GetAllCategories()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task<CategoryList<CategoryEntity>> GetGategories(string parentId)
        {
            var query = _dbContext.Categories.AsQueryable();

            if (parentId != null)
            {
                var categories = await query
                    .Where(x => x.ParentCode == parentId)
                    .ToListAsync();
                return new CategoryList<CategoryEntity>
                {
                    Items = categories
                };
            }
            else
            {
                var categories = await query.ToListAsync();
                return new CategoryList<CategoryEntity>
                {
                    Items = categories
                };
            }
        }
    }
}