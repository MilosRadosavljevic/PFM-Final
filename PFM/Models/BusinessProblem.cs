using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace PFM.Models
{
    public class BusinessProblem : Problem
    {
        [JsonPropertyName("problem")]
        public string ProblemLiteral { get; set; }

        [JsonPropertyName("message")]
        public string ProblemMessage { get; set; }

        [JsonPropertyName("details")]
        public string ProblemDetails { get; set; }
    }
}
