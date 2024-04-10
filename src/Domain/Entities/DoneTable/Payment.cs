#nullable disable
using QCheck;

namespace QCheck.Domain.Entities.DoneTable
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? SyncToken { get; set; }
        public string RealmId { get; set; }
        public string Domain { get; set; }
        public decimal? UnappliedAmt { get; set; }
        public DateTime? TxnDate { get; set; }
        public decimal? TotalAmt { get; set; }
        public bool? ProcessPayment { get; set; }
        public bool? Sparse { get; set; }
        public int? Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public int? CustomerId { get; set; }
        public string DepositToAccountValue { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentRefNum { get; set; }
        public string PrivateNote { get; set; }
        public virtual Customer Customers { get; set; }
    }
}
