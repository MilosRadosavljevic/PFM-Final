using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using PFM.Models;

namespace PFM.Commands
{
    public class CreateTransactionCommand
    {
        [Name("id")]
        public string TransactionId { get; set; }
        [Name("beneficiary-name")]
        public string BeneficiaryName { get; set; }
        [Required]
        [Name("date")]
        public DateTime Date { get; set; }
        [Required]
        [Name("direction")]
        public Direction Direction { get; set; }
        [Required]
        [Name("amount")]
        public double Amount { get; set; }
        [Name("description")]
        public string Description { get; set; }
        [Required]
        [Name("currency")]
        public string Currency { get; set; }
        [Name("mcc")]
        public MccCode? MccCode { get; set; }
        [Name("kind")]
        public TransactionKind Kind { get; set; }
    }
}
