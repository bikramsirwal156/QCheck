namespace QCheck.Domain.Entities.DoneTable;
public partial class ReturnPickup
{
    public ReturnPickup()
    {
        ReturnPickupItemLines = new HashSet<ReturnPickupItemLine>();
    }

    public int ReturnPickupId { get; set; }
    public int CustomerId { get; set; }
    public DateTime? PickupDate { get; set; }
    public string? Status { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
    public string? Territory { get; set; }
    public string? TerritoryRoute { get; set; }
    public bool IsDispatchRoute { get; set; }
    public DateTime? DispatchedDate { get; set; }
    public int Stop { get; set; }
    public string? ShippingCompany { get; set; }
    public string? Driver { get; set; }

    public virtual Customer? Customers { get; set; }
    public virtual ICollection<ReturnPickupItemLine> ReturnPickupItemLines { get; set; }
}
