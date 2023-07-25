using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class SpendingInCategory
    {
        [JsonPropertyName("catcode")]
        public string CatCode { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
