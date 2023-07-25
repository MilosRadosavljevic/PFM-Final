namespace PFM.Database.Entities
{
    public class CategoryEntity
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string? ParentCode { get; set; }

        public List<TransactionSplitEntity> Splits { get; set; }

    }
}
