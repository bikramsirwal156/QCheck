using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Domain.Entities;
public class ReturnPickupItemLine
{
    public int ReturnPickupItemLineId { get; set; }
    public int ReturnPickupId { get; set; }
    public string? Description { get; set; }
    public int? ItemId { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? UnitPrice { get; set; }
    public virtual ReturnPickup? ReturnPickup { get; set; }
}
