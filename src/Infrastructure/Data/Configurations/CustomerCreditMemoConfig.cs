using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class CustomerCreditMemoConfig : IEntityTypeConfiguration<CustomerCreditMemo>
{
    public void Configure(EntityTypeBuilder<CustomerCreditMemo> builder)
    {
        builder.HasKey(e => e.CustomerMemoId).HasName("PK_CustomerCreditMemo_CustomerCreditMemoId");
        builder.Property(e => e.CustomerMemoId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.DocNumber)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.SyncToken)
              .IsRequired()
              .HasColumnType("int");

        builder.Property(x => x.RealmId)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Domain)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Balance)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.TxnDate)
              .IsRequired()
              .HasColumnType("datetime");

        builder.Property(x => x.TotalTax)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.TotalAmt)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.Sparse)
              .IsRequired(false)
              .HasDefaultValue(false)
              .HasColumnType("bit");

        builder.Property(x => x.PrintStatus)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Id)
               .IsRequired()
               .HasColumnType("int");

        builder.Property(x => x.CreateTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.LastUpdatedTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.CustomerMemoValue)
               .IsRequired(false)
               .HasColumnType("nvarchar(max)");

        builder.Property(x => x.CustomerId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.BillAddrId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.ShipAddrId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.ApplyTaxAfterDiscount)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.RemainingCredit)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.IsDeleted)
              .IsRequired(false)
              .HasDefaultValue(false)
              .HasColumnType("bit");

        builder.HasOne(c => c.BillAddr)
               .WithMany()
               .HasForeignKey(c => c.BillAddrId)
               .HasConstraintName("FK_CustomerCreditMemo_BillAddrId");

        builder.HasOne(e => e.Customers)
               .WithMany(x => x.CustomerCreditMemoes)
               .HasForeignKey(e => e.CustomerId)
               .HasConstraintName("FK_CustomerCreditMemo_CustomerId");

        builder.HasOne(e => e.ShipAddr)
               .WithMany(x => x.CustomerCreditMemoes)
               .HasForeignKey(e => e.ShipAddrId)
               .HasConstraintName("FK_CustomerCreditMemo_ShipAddrId");
    }
}
