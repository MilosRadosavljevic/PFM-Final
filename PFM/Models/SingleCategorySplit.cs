using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class SingleCategorySplit
    {
        [JsonIgnore] public string? TransactionId { get; set; }

        [JsonPropertyName("catcode")]
        public string CategoryCode { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }
    }
}
