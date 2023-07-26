using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace PFM.Commands
{
    public class CategorizeTransactionCommand
    {
        [JsonPropertyName("catcode")]
        public string CategoryCode { get; set; }
    }
}
