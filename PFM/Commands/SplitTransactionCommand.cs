using PFM.Models;

namespace PFM.Commands
{

    public class SplitTransactionCommand
    {
        public List<SingleCategorySplit> Splits { get; set; }
    }
}
