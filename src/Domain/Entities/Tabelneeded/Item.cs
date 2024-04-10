#nullable disable
using QCheck;

namespace QCheck.Domain.Entities.DoneTable
{
    public partial class Item
    {
        public Item()
        {
            //this.SalesItemLineDetails = new HashSet<SalesItemLineDetail>();
            CustomerPricingRules = new HashSet<CustomerPricingRule>();
            //this.ItemQuantities = new HashSet<ItemQuantity>();
        }

        public int ItemId { get; set; }
        public string RealmId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public string FullyQualifiedName { get; set; }
        public bool? Taxable { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Type { get; set; }
        public int? IncomeAccountRefId { get; set; }
        public int? PurchaseCost { get; set; }
        public bool? TrackQtyOnHand { get; set; }
        public string Domain { get; set; }
        public bool? Sparse { get; set; }
        public int? Id { get; set; }
        public int? SyncToken { get; set; }
        public bool? SubItem { get; set; }
        public int? ParentRefId { get; set; }
        public int? Level { get; set; }
        public string PurchaseDesc { get; set; }
        public decimal? QtyOnHand { get; set; }
        public DateTime? InvStartDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string Sku { get; set; }
        public string ItemUniqueCode { get; set; }
        public int? AssetAccountRefId { get; set; }
        public string ItemColor { get; set; }
        public long? AttachId { get; set; }
        public int? AttachSyncToken { get; set; }
        public string ImageUrl { get; set; }
        public int? ItemSequence { get; set; }

        //public virtual IncomeAccountRef IncomeAccountRef { get; set; }
        //public virtual ICollection<SalesItemLineDetail> SalesItemLineDetails { get; set; }
        //public virtual AssetAccountRef AssetAccountRef { get; set; }
        public virtual ICollection<CustomerPricingRule> CustomerPricingRules { get; set; }
        //public virtual ICollection<ItemQuantity> ItemQuantities { get; set; }
    }
}
