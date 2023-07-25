using CsvHelper.Configuration;
using PFM.Commands;

namespace PFM.Mappings
{
    public class CategoryMap : ClassMap<CreateCategoryCommand>
    {
        public CategoryMap()
        {
            Map(m => m.CategoryCode).Name("code");
            Map(m => m.Name).Name("name");
            Map(m => m.ParentCode).Name("parent-code");
        }
    }
}
