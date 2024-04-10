#nullable disable
namespace QCheck.Domain.Entities.DoneTable
{
    public partial class CustomerCreditMemo
    {
        public int CustomerMemoId { get; set; }
        public int? DocNumber { get; set; }
        public int? SyncToken { get; set; }
        public string RealmId { get; set; }
        public string Domain { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? TxnDate { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? TotalAmt { get; set; }
        public bool? Sparse { get; set; }
        public string PrintStatus { get; set; }
        public int? Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string CustomerMemoValue { get; set; }
        public int? CustomerId { get; set; }
        public int? BillAddrId { get; set; }
        public int? ShipAddrId { get; set; }
        public bool? ApplyTaxAfterDiscount { get; set; }
        public decimal? RemainingCredit { get; set; }
        public bool IsDeleted { get; set; }
        public virtual BillAddr BillAddr { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual ShipAddr ShipAddr { get; set; }
    }
}
