#nullable disable
namespace QCheck.Domain.Entities;
public partial class Entity
{
    public Entity()
    {
        //this.DiscountLineDetails = new HashSet<DiscountLineDetail>();
        //this.EntitySyncDetails = new HashSet<EntitySyncDetail>();
        //this.EstimateInvoiceStaggings = new HashSet<EstimateInvoiceStagging>();
        //this.SalesItemLineDetails = new HashSet<SalesItemLineDetail>();
        //this.SubTotalLineDetails = new HashSet<SubTotalLineDetail>();
    }

    public int Id { get; set; }
    public string EntityName { get; set; }

    //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //public virtual ICollection<DiscountLineDetail> DiscountLineDetails { get; set; }
    //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //public virtual ICollection<EntitySyncDetail> EntitySyncDetails { get; set; }
    //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //public virtual ICollection<EstimateInvoiceStagging> EstimateInvoiceStaggings { get; set; }
    //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //public virtual ICollection<SalesItemLineDetail> SalesItemLineDetails { get; set; }
    //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //public virtual ICollection<SubTotalLineDetail> SubTotalLineDetails { get; set; }
}
