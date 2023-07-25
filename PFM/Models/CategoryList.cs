using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class CategoryList<T>
    {
        [JsonPropertyName("items")]
        public List<T> Items { get; set; }

    }
}
