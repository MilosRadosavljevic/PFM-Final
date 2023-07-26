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
                var existingCategory = _mapper.Map<CategoryEntity>(createCategoryCommand);
                await _repository.UpdateCategory(existingCategory);
                return _mapper.Map<Category>(existingCategory);                
            }
        }

        public async Task<CategoryList<Category>> GetGategories(string parentId)
        {
            var categories = await _repository.GetGategories(parentId);

            if (parentId != null && await _repository.CheckCodeValueError(parentId))
            {
                BusinessProblem busProblem = new BusinessProblem
                {
                    ProblemLiteral = "category-code-does-not-exist",
                    ProblemMessage = "Category code does not exist",
                    ProblemDetails = "Provided category code does not exist"
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
