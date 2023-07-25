using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class ValidationProblem : Problem
    {
        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
    }
}
