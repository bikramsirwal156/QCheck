using System;
using System.Collections.Generic;
using QCheck.Domain.Entities.DoneTable;
#nullable disable
namespace QCheck.Domain.Entities.Tabelneeded
{
    public partial class Bill
    {
        public Bill()
        {
            this.ItemQuantities = new HashSet<ItemQuantity>();
            this.VendorBillItemDetails = new HashSet<VendorBillItemDetail>();
        }

        public int BillId { get; set; }
        public string RealmId { get; set; }
        public int? VendorId { get; set; }
        public int? SyncToken { get; set; }
        public int? Id { get; set; }
        public string domain { get; set; }
        public DateTime? TxnDate { get; set; }
        public decimal? TotalAmt { get; set; }
        public decimal? Balance { get; set; }
        public string DocNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<ItemQuantity> ItemQuantities { get; set; }
        public virtual ICollection<VendorBillItemDetail> VendorBillItemDetails { get; set; }
    }
}
