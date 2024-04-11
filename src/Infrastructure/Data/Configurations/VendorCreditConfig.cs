using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class VendorCreditConfig : IEntityTypeConfiguration<VendorCredit>
{
    public void Configure(EntityTypeBuilder<VendorCredit> builder)
    {
        builder.HasKey(e => e.VendorCreditId).HasName("PK_VendorCredit_VendorCreditId");
        builder.Property(e => e.VendorCreditId)
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
               .WithMany(x => x.VendorCredits)
               .HasForeignKey(c => c.VendorId)
               .HasConstraintName("FK_VendorCredit_Vendor_VendorId");
    }
}
