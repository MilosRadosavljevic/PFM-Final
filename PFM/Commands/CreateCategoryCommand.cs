using CsvHelper.Configuration.Attributes;
using PFM.Models;
using System.ComponentModel.DataAnnotations;

namespace PFM.Commands
{
    public class CreateCategoryCommand
    {
        [Required]
        [Name("code")]
        public string CategoryCode { get; set; }
        
        [Required]
        [Name("name")]
        public string Name { get; set; }

        [Name("parent-code")]
        public string? ParentCode { get; set; }
    }
}
