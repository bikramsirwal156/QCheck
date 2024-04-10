#nullable disable
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Domain.Entities;
public partial class EstimateInvoiceStagging
{
    public int Id { get; set; }
    public int? EstimateId { get; set; }
    public int? InvoiceId { get; set; }
    public string Request { get; set; }
    public string Response { get; set; }
    public int EntityId { get; set; }
    public bool IsProcessed { get; set; }

    public virtual Entity Entity { get; set; }
    public virtual Estimate Estimate { get; set; }
    public virtual Invoice Invoice { get; set; }
}
