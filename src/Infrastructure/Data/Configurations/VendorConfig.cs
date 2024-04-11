using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class VendorConfig : IEntityTypeConfiguration<Vendor>
{
    public void Configure(EntityTypeBuilder<Vendor> builder)
    {
        builder.HasKey(x => x.VendorId).HasName("PK_Vendor_VendorId");
        builder.Property(x => x.VendorId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();


        builder.Property(x => x.RealmId)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Vendor1099)
             .IsRequired(false)
             .HasDefaultValue(false)
             .HasColumnType("bit");

        builder.Property(x => x.Domain)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.DisplayName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.SyncToken)
              .IsRequired(false)
              .HasColumnType("int");

        builder.Property(x => x.PrintOnCheckName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Sparse)
              .IsRequired(false)
              .HasDefaultValue(false)
              .HasColumnType("bit");

        builder.Property(x => x.Active)
              .IsRequired(false)
              .HasDefaultValue(false)
              .HasColumnType("bit");


        builder.Property(x => x.Balance)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.Id)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.CompanyName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.TaxIdentifier)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.AcctNum)
               .IsRequired(false)
               .HasColumnType("nvarchar(max)")
               .HasMaxLength(255);

        builder.Property(x => x.Email)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Phone)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.CreateTime)
              .IsRequired(false)
              .HasColumnType("datetime");

        builder.Property(x => x.LastUpdatedTime)
             .IsRequired(false)
             .HasColumnType("datetime");


        builder.HasMany(c => c.Bills)
               .WithOne(x => x.Vendor)
               .HasForeignKey(c => c.BillId)
               .HasConstraintName("FK_Vendor_Bills");

        builder.HasMany(c => c.BillPayments)
               .WithOne(x => x.Vendor)
               .HasForeignKey(c => c.BillPaymentId)
               .HasConstraintName("FK_Vendor_BillPayments");

        builder.HasMany(c => c.VendorCredits)
               .WithOne(x => x.Vendor)
               .HasForeignKey(c => c.VendorCreditId)
               .HasConstraintName("FK_Vendor_VendorCredits");

        builder.HasMany(c => c.PurchaseOrders)
               .WithOne(x => x.Vendor)
               .HasForeignKey(c => c.PurchaseOrderId)
               .HasConstraintName("FK_Vendor_PurchaseOrders");

        builder.HasMany(e => e.TabConfigurations)
               .WithOne(x => x.Vendor)
               .HasForeignKey(e => e.TabConfigurationId)
               .HasConstraintName("FK_Vendor_TabConfigurations");
    }
}
