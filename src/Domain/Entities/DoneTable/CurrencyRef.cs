#nullable disable
using QCheck;

namespace QCheck.Domain.Entities.DoneTable;

public partial class CurrencyRef
{
    public int CurrencyRefId { get; set; }

    public string RealmId { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public virtual ICollection<Customer> Customers { get; set; }
    public virtual ICollection<Estimate> Estimates { get; set; }
    public virtual ICollection<Invoice> Invoices { get; set; }
}
