#nullable disable
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Domain.Entities.Tabelneeded;
public class TabConfiguration
{
    public int TabConfigurationId { get; set; }
    public string RealmId { get; set; }
    public string TabName { get; set; }
    public string TabConfiguraton { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string UpdatedBy { get; set; }
    public int? PrintSequence { get; set; }
    public bool IsHideFromCustomer { get; set; }
    public string ImageUrl { get; set; }
    public int? VendorId { get; set; }

    public virtual Vendor Vendor { get; set; }
}
