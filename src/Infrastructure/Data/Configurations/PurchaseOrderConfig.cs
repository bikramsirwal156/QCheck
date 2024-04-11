using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.Tabelneeded;

namespace QCheck.Infrastructure.Data.Configurations;
public class PurchaseOrderConfig : IEntityTypeConfiguration<PurchaseOrder>
{
    public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
    {
        builder.HasKey(e => e.PurchaseOrderId).HasName("PK_PurchaseOrder_PurchaseOrderId");
        builder.Property(e => e.PurchaseOrderId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();


        builder.Property(x => x.VendorId)
              .IsRequired()
              .HasColumnType("int");

        builder.Property(x => x.SyncToken)
              .IsRequired()
              .HasColumnType("int");

        builder.Property(x => x.Id)
               .IsRequired()
               .HasColumnType("int");

        builder.Property(x => x.Domain)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.TxnDate)
             .IsRequired()
             .HasColumnType("datetime");

        builder.Property(x => x.DocNumber)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.DueDate)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.Status)
              .IsRequired(false)
              .HasColumnType("nvarchar")
              .HasMaxLength(255);

        builder.Property(x => x.CreateTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.LastUpdatedTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x =>x.VendorMemo)
             .IsRequired(false)
             .HasColumnType("nvarchar(max)")
             .HasMaxLength(255);

        builder.HasMany(c => c.PurchaseOrderItemDetails)
               .WithOne(x=>x.PurchaseOrder)
               .HasForeignKey(c => c.PurchaseOrderItemId)
               .HasConstraintName("FK_PurchaseOrderItemDetails_PurchaseOrderItemId");
    }
}
