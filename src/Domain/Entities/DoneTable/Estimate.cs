#nullable disable
using QCheck.Domain.Entities.Tabelneeded;

namespace QCheck.Domain.Entities.DoneTable
{
    public partial class Estimate
    {
        public Estimate()
        {
            EstimateInvoiceStaggings = new HashSet<EstimateInvoiceStagging>();
        }

        public int EstimateId { get; set; }
        public string RealmId { get; set; }
        public string Domain { get; set; }
        public bool? Sparse { get; set; }
        public int? Id { get; set; }
        public int? SyncToken { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public int? DocNumber { get; set; }
        public DateTime? TxnDate { get; set; }
        public int? CurrencyRefId { get; set; }
        public string TxnStatus { get; set; }
        public int? TxnTaxDetail { get; set; }
        public string CustomerMemo { get; set; }
        public int? BillAddrId { get; set; }
        public int? ShipAddrId { get; set; }
        public bool? FreeFormAddress { get; set; }
        public decimal? TotalAmt { get; set; }
        public bool? ApplyTaxAfterDiscount { get; set; }
        public string PrintStatus { get; set; }
        public string EmailStatus { get; set; }
        public string BillEmailAddress { get; set; }
        public int? CustomerId { get; set; }
        public string PrivateNote { get; set; }
        public bool IsOrderProcessed { get; set; }
        public int? CustomFieldId { get; set; }
        public bool IsExcelUpload { get; set; }
        public string OrderStatus { get; set; }
        public string Territory { get; set; }
        public string Comments { get; set; }
        public string TerritoryRoute { get; set; }
        public string AssignedTo { get; set; }
        public bool? IsCreatedByCustomer { get; set; }
        public int? CreationType { get; set; }
        public bool? IsDataUpdating { get; set; }

        public virtual ICollection<EstimateInvoiceStagging> EstimateInvoiceStaggings { get; set; }
        public virtual BillAddr BillAddr { get; set; }
        public virtual CurrencyRef CurrencyRefs { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual CustomField CustomField { get; set; }
        public virtual ShipAddr ShipAddr { get; set; }
    }
}
