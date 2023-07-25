using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class Transaction
    {
        [JsonPropertyName("id")]
        public string TransactionId { get; set; }

        [JsonPropertyName("beneficiary-name")]
        public string BeneficiaryName { get; set; }

        [JsonPropertyName("date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        [JsonPropertyName("direction")]
        public Direction Direction { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("mcc")]
        public MccCode? MccCode { get; set; }

        [JsonPropertyName("kind")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TransactionKind Kind { get; set; }

        [JsonPropertyName("catcode")]
        public string? catCode { get; set; }

        [JsonPropertyName("splits")]
        public List<SingleCategorySplit>? Splits { get; set; }
    }
}
