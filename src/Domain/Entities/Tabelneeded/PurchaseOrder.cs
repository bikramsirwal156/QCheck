#nullable disable
namespace QCheck.Domain.Entities.Tabelneeded
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderItemDetails = new HashSet<PurchaseOrderItemDetail>();
        }
        public int PurchaseOrderId { get; set; }
        public int? VendorId { get; set; }
        public int? SyncToken { get; set; }
        public int? Id { get; set; }
        public string Domain { get; set; }
        public DateTime? TxnDate { get; set; }
        public string DocNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string Status { get; set; }

        public virtual ICollection<PurchaseOrderItemDetail> PurchaseOrderItemDetails { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
