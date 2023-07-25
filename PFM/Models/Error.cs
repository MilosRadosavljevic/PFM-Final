using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class Error
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; } // json polje na koje se odnosi

        [JsonPropertyName("error")]
        public string Err {get; set;} // tip greske koja se desila

        [JsonPropertyName("message")]
        public string Message { get; set; } // opis greske
    }
}
