using System;
using System.Collections.Generic;
#nullable disable
namespace QCheck.Domain.Entities.Tabelneeded
{
    public partial class BillPayment
    {
        public int BillPaymentId { get; set; }
        public string RealmId { get; set; }
        public int? VendorId { get; set; }
        public string DocNumber { get; set; }
        public int? SyncToken { get; set; }
        public int? Id { get; set; }
        public DateTime? TxnDate { get; set; }
        public decimal? TotalAmt { get; set; }
        public string PayType { get; set; }
        public bool? sparse { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
