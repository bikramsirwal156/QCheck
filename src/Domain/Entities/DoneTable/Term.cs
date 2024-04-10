#nullable disable
using QCheck;

namespace QCheck.Domain.Entities.DoneTable
{
    public partial class Term
    {
        public Term()
        {
            Customers = new HashSet<Customer>();
        }

        public int TermId { get; set; }
        public int? SyncToken { get; set; }
        public string Domain { get; set; }
        public string Name { get; set; }
        public decimal? DiscountPercent { get; set; }
        public int? DiscountDays { get; set; }
        public string Type { get; set; }
        public bool? Sparse { get; set; }
        public bool? Active { get; set; }
        public int? DueDays { get; set; }
        public int? Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
