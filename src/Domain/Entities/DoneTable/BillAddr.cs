
#nullable disable
using QCheck;

namespace QCheck.Domain.Entities.DoneTable
{

    public partial class BillAddr
    {
        public BillAddr()
        {
            Customers = new List<Customer>();
        }

        public int BillAddrId { get; set; }

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

        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
