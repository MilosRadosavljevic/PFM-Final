using PFM.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFM.Database.Entities
{
    public class TransactionEntity
    {
        public string Id { get; set; }
        public string BeneficiaryName { get; set; }
        public DateTime Date { get; set; }
        public Direction Direction { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public MccCode? MccCode { get; set; }
        public TransactionKind Kind { get; set; }

        [ForeignKey("catCode")]
        public string? catCode { get; set; }
        public CategoryEntity Category { get; set; }
        public List<TransactionSplitEntity> Splits { get; set; }
    }
}
