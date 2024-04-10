using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class ReturnPickupConfig : IEntityTypeConfiguration<ReturnPickup>
{
    public void Configure(EntityTypeBuilder<ReturnPickup> builder)
    {
        builder.HasKey(e => e.ReturnPickupId).HasName("PK_ReturnPickup_ReturnPickup");
        builder.Property(e => e.ReturnPickupId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.CustomerId)
               .IsRequired()
               .HasColumnType("int");

        builder.Property(x => x.PickupDate)
               .IsRequired()
               .HasColumnType("datetime");

        builder.Property(x => x.Territory)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.TerritoryRoute)
              .IsRequired(false)
              .HasColumnType("nvarchar")
              .HasMaxLength(255);

        builder.Property(x => x.Status)
               .IsRequired(false)
               .HasColumnType("nvarchar");

        builder.Property(x => x.IsDispatchRoute)
               .IsRequired()
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.DispatchedDate)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.Stop)
               .IsRequired()
               .HasColumnType("int");

        builder.Property(x => x.ShippingCompany)
               .IsRequired(false)
               .HasColumnType("nvarchar(max)");

        builder.Property(x => x.Driver)
               .IsRequired(false)
               .HasColumnType("nvarchar(max)");

        builder.Property(x => x.CreatedOn)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.UpdatedOn)
               .IsRequired(false)
               .HasColumnType("datetime");
        
        builder.HasOne(c => c.Customers)
               .WithMany(e => e.ReturnPickups)
               .HasForeignKey(c => c.CustomerId)
               .HasConstraintName("FK_ReturnPickup_CustomerId");

        builder.HasMany(c => c.ReturnPickupItemLines)
               .WithOne(x => x.ReturnPickup)
               .HasForeignKey(c => c.ReturnPickupItemLineId)
               .HasConstraintName("FK_ReturnPickup_ReturnPickupItemLines");
    }
}
