using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class Error
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; } 

        [JsonPropertyName("error")]
        public string Err {get; set;} 

        [JsonPropertyName("message")]
        public string Message { get; set; } 
    }
}
