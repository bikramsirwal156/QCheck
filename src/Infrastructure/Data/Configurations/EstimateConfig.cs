using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class EstimateConfig : IEntityTypeConfiguration<Estimate>
{
    public void Configure(EntityTypeBuilder<Estimate> builder)
    {
        builder.HasKey(e => e.EstimateId).HasName("PK_Estimate_EstimateId");
        builder.Property(e => e.EstimateId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.RealmId)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Domain)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Sparse)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.Id)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.SyncToken)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.CreateTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.LastUpdatedTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.DocNumber)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.TxnDate)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.CurrencyRefId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.TxnStatus)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.TxnTaxDetail)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.CustomerMemo)
               .IsRequired(false)
               .HasColumnType("nvarchar");

        builder.Property(x => x.BillAddrId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.ShipAddrId)
              .IsRequired(false)
              .HasColumnType("int");

        builder.Property(x => x.FreeFormAddress)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.TotalAmt)
               .IsRequired(false)
               .HasColumnType("decimal(18,6))");

        builder.Property(x => x.ApplyTaxAfterDiscount)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.PrintStatus)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.EmailStatus)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.BillEmailAddress)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.CustomerId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.PrivateNote)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.IsOrderProcessed)
               .IsRequired()
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.CustomFieldId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.IsExcelUpload)
               .IsRequired()
               .HasColumnType("bit");

        builder.Property(x => x.OrderStatus)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Territory)
              .IsRequired(false)
              .HasColumnType("nvarchar")
              .HasMaxLength(255);

        builder.Property(x => x.Comments)
              .IsRequired(false)
              .HasColumnType("nvarchar(max)");


        builder.Property(x => x.AssignedTo)
               .IsRequired(false)
               .HasColumnType("nvarchar");

        builder.Property(x => x.IsCreatedByCustomer)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.CreationType)
               .IsRequired(false)
               .HasColumnType("int")
               .HasMaxLength(255);

        builder.Property(x => x.IsDataUpdating)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");


        builder.HasMany(c => c.EstimateInvoiceStaggings)
               .WithOne(e => e.Estimate)
               .HasForeignKey(c => c.EstimateId)
               .HasConstraintName("FK_EstimateInvoiceStagging_Estimate");

        builder.HasOne(c => c.BillAddr)
               .WithMany()
               .HasForeignKey(c => c.BillAddrId)
               .HasConstraintName("FK_Estimate_BillAddrId");

        builder.HasOne(e => e.CurrencyRefs)
               .WithMany(x => x.Estimates)
               .HasForeignKey(e => e.CurrencyRefId)
               .HasConstraintName("FK_Estimate_CurrencyRefId");

        builder.HasOne(e => e.Customers)
               .WithMany(x => x.Estimates)
               .HasForeignKey(e => e.EstimateId)
               .HasConstraintName("FK_Estimate_CustomerId");

        builder.HasOne(e => e.CustomField)
               .WithMany(x=>x.Estimates)
               .HasForeignKey(e => e.CustomFieldId)
               .HasConstraintName("FK_Estimate_CustomFieldId");

        builder.HasOne(e => e.ShipAddr)
               .WithMany(x=>x.Estimates)
               .HasForeignKey(e => e.ShipAddrId)
               .HasConstraintName("FK_Estimate_ShipAddrId");
    }
}
