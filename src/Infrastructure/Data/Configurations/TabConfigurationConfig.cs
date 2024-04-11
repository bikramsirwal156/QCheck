using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class TabConfigurationConfig : IEntityTypeConfiguration<TabConfiguration>
{
    public void Configure(EntityTypeBuilder<TabConfiguration> builder)
    {
        builder.HasKey(e => e.TabConfigurationId).HasName("PK_TabConfiguration_TabConfigurationId");
        builder.Property(e => e.TabConfigurationId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.RealmId)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.TabName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.TabConfiguraton)
               .IsRequired()
               .HasColumnType("nvarchar(max)");

        builder.Property(x => x.CreatedBy)
             .IsRequired(false)
             .HasColumnType("nvarchar")
             .HasMaxLength(255);

        builder.Property(x => x.CreatedDate)
              .IsRequired(false)
              .HasColumnType("datetime");

        builder.Property(x => x.UpdatedBy)
            .IsRequired(false)
            .HasColumnType("nvarchar")
            .HasMaxLength(255);

        builder.Property(x => x.LastUpdated)
              .IsRequired()
              .HasColumnType("datetime");

        builder.Property(x => x.PrintSequence)
                .IsRequired(false)
                .HasColumnType("int");

        builder.Property(x => x.IsHideFromCustomer)
              .IsRequired(false)
              .HasDefaultValue(false)
              .HasColumnType("bit");

        builder.Property(x => x.ImageUrl)
               .IsRequired(false)
               .HasColumnType("nvarchar(max)");

        builder.Property(x => x.VendorId)
                 .IsRequired(false)
                 .HasColumnType("int");

        builder.HasOne(c => c.Vendor)
               .WithMany(x => x.TabConfigurations)
               .HasForeignKey(c => c.VendorId)
               .HasConstraintName("FK_TabConfiguration _Vendor_VednorId");
    }
}
