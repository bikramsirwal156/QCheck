using QCheck.Domain.Entities.DoneTable;
#nullable disable
namespace QCheck.Domain.Entities.Tabelneeded;
public class ItemQuantity
{
    public ItemQuantity()
    {
        ItemQtyLocations = new HashSet<ItemQtyLocation>();
    }

    public int ItemQuantityId { get; set; }
    public int? ItemId { get; set; }
    public int? BillId { get; set; }
    public decimal? Price { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }

    public virtual Item Item { get; set; }
    public virtual Bill Bill { get; set; }
    public virtual ICollection<ItemQtyLocation> ItemQtyLocations { get; set; }
}
