using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class BillPaymentConfig : IEntityTypeConfiguration<BillPayment>
{
    public void Configure(EntityTypeBuilder<BillPayment> builder)
    {
        builder.HasKey(e => e.BillPaymentId).HasName("PK_BillPayment_BillPaymentId");
        builder.Property(e => e.BillPaymentId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.RealmId)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.VendorId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.DocNumber)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.SyncToken)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.Id)
              .IsRequired(false)
              .HasColumnType("int");

        builder.Property(x => x.TxnDate)
              .IsRequired(false)
              .HasColumnType("datetime");

        builder.Property(x => x.TotalAmt)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.PayType)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Sparse)
              .IsRequired(false)
              .HasDefaultValue(false)
              .HasColumnType("bit");

        builder.Property(x => x.CreateTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.LastUpdatedTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.HasOne(c => c.Vendor)
               .WithMany(x=>x.BillPayments)
               .HasForeignKey(c => c.VendorId)
               .HasConstraintName("FK_Bill_Payment_Vendor_VendorId");
    }
}
