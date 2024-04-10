namespace QCheck.Domain.Entities.DoneTable;
public partial class OrderReceived
{
    public int OrderReceivedId { get; set; }
    public int CustomerId { get; set; }
    public bool IsEstimateCreated { get; set; }
    public DateTime? TxnDate { get; set; }
    public string? Comments { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string? OrderStatus { get; set; }
    public string? PrivateNotes { get; set; }
    public virtual Customer? Customers { get; set; }
}
