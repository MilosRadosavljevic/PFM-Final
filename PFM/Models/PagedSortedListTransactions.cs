using System.Text.Json.Serialization;
using PFM.Models;

namespace PFM.Models
{
    public class PagedSortedListTransactions<T>
    {
        [JsonPropertyName("page-size")]
        public int PageSize { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("total-count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("total-pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("sort-by")]
        public string SortBy { get; set; }

        [JsonPropertyName("sort-order")]
        public SortOrder SortOrder { get; set; }

        [JsonPropertyName("items")]
        public List<T> Items { get; set; }

        [JsonIgnore]
        [JsonPropertyName("start-date")]
        public DateTime? StartDate { get; set; }

        [JsonIgnore]
        [JsonPropertyName("end-date")]
        public DateTime? EndDate { get; set; }

        [JsonIgnore]
        [JsonPropertyName("transaction-kind")]
        public TransactionKind? TransactionKind { get; set; }
    }
}
