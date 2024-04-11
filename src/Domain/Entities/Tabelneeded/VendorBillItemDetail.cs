#nullable disable
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Domain.Entities.Tabelneeded;
public partial class VendorBillItemDetail
{
    public int BillItemId { get; set; }
    public int? BillId { get; set; }
    public int? ItemId { get; set; }
    public string RealmId { get; set; }
    public string ItemName { get; set; }
    public decimal? Price { get; set; }
    public string ItemDescription { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? Id { get; set; }

    public virtual Bill Bill { get; set; }
}
