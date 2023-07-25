using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PFM.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Direction
    {
        [Description("Debit")]
        [JsonPropertyName("d")]
        d,
        [Description("Credit")]
        [JsonPropertyName("c")]
        c,
    }
}
