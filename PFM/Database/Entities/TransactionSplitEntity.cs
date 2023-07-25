namespace PFM.Database.Entities
{
    public class TransactionSplitEntity
    {
        public string TransactionId { get; set; }
        public TransactionEntity Transaction { get; set; }
        public string CategoryCode { get; set; }
        public CategoryEntity Category { get; set; }
        public double Amount { get; set; }
    }
}
