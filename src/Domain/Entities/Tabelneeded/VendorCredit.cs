
#nullable disable
namespace QCheck.Domain.Entities.Tabelneeded
{
    public partial class VendorCredit
    {
        public int VendorCreditId { get; set; }
        public string RealmId { get; set; }
        public int? VendorId { get; set; }
        public int? SyncToken { get; set; }
        public int? Id { get; set; }
        public DateTime? TxnDate { get; set; }
        public decimal? TotalAmt { get; set; }
        public bool? Sparse { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
