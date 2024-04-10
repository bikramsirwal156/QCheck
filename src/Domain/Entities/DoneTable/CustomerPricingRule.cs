
#nullable disable
using QCheck;

namespace QCheck.Domain.Entities.DoneTable;
public class CustomerPricingRule
{
    public int CustomerPricingRuleId { get; set; }
    public int CustomerId { get; set; }
    public int ItemId { get; set; }
    public decimal? Price { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }
    public int PricingRuleId { get; set; }
    public virtual Customer Customers { get; set; }
    public virtual Item Item { get; set; }
    public virtual PricingRule PricingRule { get; set; }
}
