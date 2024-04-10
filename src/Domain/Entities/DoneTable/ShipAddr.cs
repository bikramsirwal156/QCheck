#nullable disable
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Domain.Entities.DoneTable;

public partial class ShipAddr
{
    public ShipAddr()
    {
        Customers = new HashSet<Customer>();
        Estimates = new HashSet<Estimate>();
        Invoices = new HashSet<Invoice>();
        CustomerCreditMemoes = new HashSet<CustomerCreditMemo>();
    }

    public int ShipAddrId { get; set; }
    public string RealmId { get; set; }
    public int? Id { get; set; }
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string Line3 { get; set; }
    public string Line4 { get; set; }
    public string Line5 { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public string CountrySubDivisionCode { get; set; }
    public string PostalCode { get; set; }
    public string PostalCodeSuffix { get; set; }
    public string Lat { get; set; }
    public string Long { get; set; }
    public string Tag { get; set; }
    public string Note { get; set; }

    public virtual ICollection<Customer> Customers { get; set; }
    public virtual ICollection<Estimate> Estimates { get; set; }
    public virtual ICollection<Invoice> Invoices { get; set; }
    public virtual ICollection<CustomerCreditMemo> CustomerCreditMemoes { get; set; }
}
