using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class SpendingByCategory<T>
    {
        [JsonPropertyName("groups")]
        public List<SpendingInCategory> Groups { get; set; }
    }
}
