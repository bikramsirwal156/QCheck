namespace QCheck.Domain.Entities.Tabelneeded;
#nullable disable
public partial class ItemQtyLocation
{
    public int ItemQtyLocationId { get; set; }
    public int? ItemQuantityId { get; set; }
    public decimal? Quantity { get; set; }
    public int? RackLocationId { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string Optional { get; set; }
    public decimal? QtyAllocated { get; set; }
    public decimal? QtyInHand { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }

    public virtual ItemQuantity ItemQuantity { get; set; }
    public virtual RackLocation RackLocation { get; set; }
}
