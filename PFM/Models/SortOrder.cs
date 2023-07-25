using System.Text.Json.Serialization;

namespace PFM.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortOrder
    {
        Asc,
        Desc,
    }
}
