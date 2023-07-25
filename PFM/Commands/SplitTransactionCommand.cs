using Microsoft.AspNetCore.Mvc;
using PFM.Models;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace PFM.Commands
{

    public class SplitTransactionCommand
    {
        [JsonPropertyName("splits")]
        public List<SingleCategorySplit> Splits { get; set; }
    }
}
