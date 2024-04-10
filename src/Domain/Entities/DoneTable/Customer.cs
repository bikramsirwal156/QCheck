using QCheck.Domain.Entities.DoneTable;
using QCheck.Domain.QCheck.Domain.Entities;

namespace QCheck.Domain.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            BillAddr = new BillAddr();
            CurrencyRef = new CurrencyRef();
            CustomerCreditMemoes = new List<CustomerCreditMemo>();
            CustomerPricingRules = new List<CustomerPricingRule>();
            DefaultTaxCodeRef = new DefaultTaxCodeRef();
            Estimates = new List<Estimate>();
            Invoices = new List<Invoice>();
            OrderReceiveds = new List<OrderReceived>();
            Payments = new List<Payment>();
            ReturnPickups = new List<ReturnPickup>();
            ShipAddr = new ShipAddr();
            Term = new Term();
        }
        public required int CustomerId { get; set; }
        public bool? Active { get; set; }
        public string? CompanyName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? DefaultTaxCodeRefId { get; set; }
        public string? DefaultTerritory { get; set; }
        public string? DisplayName { get; set; }
        public string? Domain { get; set; }
        public string? FamilyName { get; set; }
        public string? FullyQualifiedName { get; set; }
        public string? GivenName { get; set; }
        public required bool HasLoginAccess { get; set; }
        public int? BillAddrId { get; set; }
        public bool? BillWithParent { get; set; }
        public decimal? Balance { get; set; }
        public decimal? BalanceWithJobs { get; set; }
        public int? CurrencyRefId { get; set; }
        public int? Id { get; set; }
        public bool? IsDisabled { get; set; }
        public bool? Job { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public decimal? OverdueAmount { get; set; }
        public bool? ProblematicCustomer { get; set; }
        public string? PersonalNote { get; set; }
        public string? PreferredDeliveryMethod { get; set; }
        public string? PrintOnCheckName { get; set; }
        public required string RealmId { get; set; }
        public decimal? ShippingPrice { get; set; }
        public int? ShipAddrId { get; set; }
        public bool? ShowInReport { get; set; }
        public int? SyncToken { get; set; }
        public bool? Sparse { get; set; }
        public string? Mobile { get; set; }
        public string? PrimaryEmailAddr { get; set; }
        public string? PrimaryPhone { get; set; }
        public bool? Taxable { get; set; }
        public int? TermId { get; set; }
        public string? WhatsappNumber { get; set; }

        public virtual BillAddr BillAddr { get; set; }
        public virtual CurrencyRef CurrencyRef { get; set; }
        public virtual DefaultTaxCodeRef DefaultTaxCodeRef { get; set; }
        public virtual ShipAddr ShipAddr { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<CustomerCreditMemo> CustomerCreditMemoes { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<CustomerPricingRule> CustomerPricingRules { get; set; }
        public virtual ICollection<ReturnPickup> ReturnPickups { get; set; }
        public virtual ICollection<OrderReceived> OrderReceiveds { get; set; }
        public virtual Term Term { get; set; }
    }
}
