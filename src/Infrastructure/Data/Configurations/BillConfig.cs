﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class BillConfig : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.HasKey(e => e.BillId).HasName("PK_Bill_BillId");
        builder.Property(e => e.BillId)
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

        builder.Property(x => x.TotalAmt)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.Balance)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.DocNumber)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.DueDate)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.CreateTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.LastUpdatedTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.HasOne(c => c.Vendor)
               .WithMany(x => x.Bills)
               .HasForeignKey(c => c.VendorId)
               .HasConstraintName("FK_Vendor_VendorId");

        builder.HasMany(e => e.ItemQuantities)
               .WithOne(x => x.Bill)
               .HasForeignKey(e => e.ItemId)
               .HasConstraintName("FK_ItemQuantities_ItemId");

        builder.HasMany(e => e.VendorBillItemDetails)
               .WithOne(x => x.Bill)
               .HasForeignKey(e => e.BillItemId)
               .HasConstraintName("FK_VendorBillItemDetails_BillItemId");
    }
}
