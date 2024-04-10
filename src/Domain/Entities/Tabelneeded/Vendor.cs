using QCheck.Domain.Entities.DoneTable;
#nullable disable
namespace QCheck.Domain.Entities.Tabelneeded
{
    public partial class Vendor
    {
        public Vendor()
        {
            Bills = new HashSet<Bill>();
            BillPayments = new HashSet<BillPayment>();
            VendorCredits = new HashSet<VendorCredit>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            TabConfigurations = new HashSet<TabConfiguration>();
        }

        public int VendorId { get; set; }
        public string RealmId { get; set; }
        public bool? Vendor1099 { get; set; }
        public string Domain { get; set; }
        public string DisplayName { get; set; }
        public int? SyncToken { get; set; }
        public string PrintOnCheckName { get; set; }
        public bool? Sparse { get; set; }
        public bool? Active { get; set; }
        public decimal? Balance { get; set; }
        public int? Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxIdentifier { get; set; }
        public string AcctNum { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<BillPayment> BillPayments { get; set; }
        public virtual ICollection<VendorCredit> VendorCredits { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<TabConfiguration> TabConfigurations { get; set; }
    }
}
