#nullable disable
using QCheck;


#nullable disable
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Domain.Entities.Tabelneeded;
public partial class CustomField
{
    public CustomField()
    {
        Estimates = new HashSet<Estimate>();
        Invoices = new HashSet<Invoice>();
    }

    public int CustomFieldId { get; set; }
    public string RealmId { get; set; }
    public int EntityId { get; set; }
    public int? DefinitionId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string StringValue { get; set; }

    public virtual ICollection<Estimate> Estimates { get; set; }
    public virtual ICollection<Invoice> Invoices { get; set; }
}
