using CsvHelper.Configuration;
using PFM.Commands;

namespace PFM.Mappings
{
    public class TransactionMap : ClassMap<CreateTransactionCommand>
    {
        public TransactionMap()
        {
            Map(m => m.TransactionId).Name("id");
            Map(m => m.BeneficiaryName).Name("beneficiary-name");
            Map(m => m.Date).Name("date");
            Map(m => m.Direction).Name("direction");
            Map(m => m.Amount).Name("amount");
            Map(m => m.Description).Name("description");
            Map(m => m.Currency).Name("currency");
            Map(m => m.MccCode).Name("mcc");
            Map(m => m.Kind).Name("kind");
        }
    }
}
