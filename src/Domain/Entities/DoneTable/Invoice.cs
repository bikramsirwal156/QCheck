#nullable disable
using QCheck.Domain.Entities.Tabelneeded;

namespace QCheck.Domain.Entities.DoneTable
{
    public partial class Invoice
    {
        public Invoice()
        {
            EstimateInvoiceStaggings = new HashSet<EstimateInvoiceStagging>();
        }

        public int InvoiceId { get; set; }
        public decimal Deposit { get; set; }
        public string RealmId { get; set; }
        public bool AllowIPNPayment { get; set; }
        public bool AllowOnlinePayment { get; set; }
        public bool AllowOnlineCreditCardPayment { get; set; }
        public bool AllowOnlineACHPayment { get; set; }
        public string Domain { get; set; }
        public bool Sparse { get; set; }
        public int Id { get; set; }
        public int SyncToken { get; set; }
        public int? CustomFieldId { get; set; }
        public int? DocNumber { get; set; }
        public DateTime TxnDate { get; set; }
        public int? CurrencyRefId { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerMemo { get; set; }
        public int? BillAddrId { get; set; }
        public int? ShipAddrId { get; set; }
        public bool? FreeFormAddress { get; set; }
        public int SalesTermRefvalue { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? TotalAmt { get; set; }
        public bool? ApplyTaxAfterDiscount { get; set; }
        public string PrintStatus { get; set; }
        public string EmailStatus { get; set; }
        public string BillEmailAddress { get; set; }
        public decimal? Balance { get; set; }
        public string PrivateNote { get; set; }
        public string DeliveryInfoDeliveryType { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public bool IsDispatchRoute { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public string Comment { get; set; }
        public int Stop { get; set; }
        public string ShippingCompany { get; set; }
        public string Driver { get; set; }
        public string AssignedTo { get; set; }

        public virtual ICollection<EstimateInvoiceStagging> EstimateInvoiceStaggings { get; set; }
        public virtual BillAddr BillAddr { get; set; }
        public virtual CurrencyRef CurrencyRefs { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual CustomField CustomField { get; set; }
        public virtual ShipAddr ShipAddr { get; set; }
    }
}
