using AutoMapper;
using PFM.Commands;
using PFM.Database.Entities;
using PFM.Database.Repositories;
using PFM.Models;

namespace PFM.Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _repository;
        IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Category> CreateCategory(CreateCategoryCommand createCategoryCommand)
        {
            var checkIfCategoryExists = await CheckIfCategoryExistsAsync(createCategoryCommand.CategoryCode);
            if (!checkIfCategoryExists)
            {
                var newCategoryEntity = _mapper.Map<CategoryEntity>(createCategoryCommand);
                await _repository.CreateCategory(newCategoryEntity);
                return _mapper.Map<Category>(newCategoryEntity);
            }
            else
            {
                // updating name, parent-code if category already exists
                var existingCategory = _mapper.Map<CategoryEntity>(createCategoryCommand);
                await _repository.UpdateCategory(existingCategory);
                return _mapper.Map<Category>(existingCategory);                
            }
        }

        public async Task<CategoryList<Category>> GetGategories(string parentId)
        {
            var categories = await _repository.GetGategories(parentId);
            BusinessProblem busProblem;

            if (categories == null)
            {
                busProblem = new BusinessProblem
                {
                    ProblemLiteral = "Parent-id-does-not-exist",
                    ProblemMessage = "Parent id does not exist",
                    ProblemDetails = "Provided parent id does not exist"
                };
                throw new CustomException(busProblem);
            }
            return _mapper.Map<CategoryList<Category>>(categories);
        }

        private async Task<bool> CheckIfCategoryExistsAsync(string categoryCode)
        {
            var category = await _repository.GetCategoryByCode(categoryCode);
            if (category == null)
            {
                return false;
            }
            return true;
        }

    }
}
