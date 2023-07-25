using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace PFM.Commands
{
    public class CategorizeTransactionCommand
    {
        public string CategoryCode { get; set; }
    }
}
