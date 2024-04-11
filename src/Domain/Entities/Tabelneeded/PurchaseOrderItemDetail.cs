#nullable disable
namespace QCheck.Domain.Entities.Tabelneeded;
public partial class PurchaseOrderItemDetail
{
    public int PurchaseOrderItemId { get; set; }
    public int? PurchaseOrderId { get; set; }
    public int? ItemId { get; set; }
    public string ItemName { get; set; }
    public decimal? CostPrice { get; set; }
    public string ItemDescription { get; set; }
    public decimal? Quantity { get; set; }
    public int? Id { get; set; }
    public DateTime? CreateTime { get; set; }
    public DateTime? LastUpdatedTime { get; set; }
    public virtual PurchaseOrder PurchaseOrder { get; set; }
}
