#nullable disable
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Domain.Entities;
public partial class PricingRule
{
    public PricingRule()
    {
        CustomerPricingRules = new HashSet<CustomerPricingRule>();
    }
    public int Id { get; set; }
    public string RuleName { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<CustomerPricingRule> CustomerPricingRules { get; set; }
}
