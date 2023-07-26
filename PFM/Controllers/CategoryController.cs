using CsvHelper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PFM.Commands;
using PFM.Mappings;
using PFM.Models;
using PFM.Services;
using System.Globalization;

namespace PFM.Controllers
{
    [EnableCors("MyCORSPolicy")]
    [ApiController]
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        private readonly ILogger<TransactionController> _logger;

        public CategoryController(ILogger<TransactionController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories([FromQuery(Name = "parent-id")] string? parentId = null)
        {
            try
            {
                var categories = await _categoryService.GetGategories(parentId);
                return Ok(categories);
            }
            catch (CustomException ex)
            {
                if (ex.Problem is BusinessProblem)
                {
                    return new ObjectResult(ex.Problem) { StatusCode = 440 };
                }
                return new ObjectResult(ex.Problem) { StatusCode = 400 };
            }
        }

        [HttpPost("import")]
        public async Task<IActionResult> ImportCategories(IFormFile? file)
        {
            try
            {
                ValidationProblem valProblem;
                List<Error> validationErrors = new List<Error>();
                if (file == null || file.Length == 0)
                {
                    validationErrors.Add(new Error
                    {
                        Message = "File to import is empty or not selected.",
                        Tag = "file",
                        Err = "invalid-or-empty-file"
                    });
                    valProblem = new ValidationProblem
                    {
                        Errors = validationErrors
                    };
                    throw new CustomException(valProblem);
                }
                file = Request.Form.Files[0];
                using (var reader = new StreamReader(file.OpenReadStream()))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<CategoryMap>();
                    try
                    {
                        var records = csv.GetRecords<CreateCategoryCommand>().ToList();
                        foreach (var record in records)
                        {
                            await _categoryService.CreateCategory(record);
                        }
                    }
                    catch (HeaderValidationException ex)
                    {
                        validationErrors.Add(new Error
                        {
                            Message = "Invalid or missing headers in the file.",
                            Tag = "file",
                            Err = "invalid-headers"
                        });
                        valProblem = new ValidationProblem
                        {
                            Errors = validationErrors
                        };
                        throw new CustomException(valProblem);
                    }                    
                }
                return Ok();
            }
            catch (CustomException ex)
            {
                if (ex.Problem is BusinessProblem)
                {
                    return new ObjectResult(ex.Problem) { StatusCode = 440 };
                }
                return new ObjectResult(ex.Problem) { StatusCode = 400 };
            }
        }

    }
}
