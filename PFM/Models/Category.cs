using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class Category
    {
        [JsonPropertyName("code")]
        public string CategoryCode { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("parent-code")]
        public string? ParentCode { get; set; }
    }
}