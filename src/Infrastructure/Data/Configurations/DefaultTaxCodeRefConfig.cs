using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities;
using QCheck.Domain.QCheck.Domain.Entities;

namespace QCheck.Infrastructure.Data.Configurations;
public class DefaultTaxCodeRefConfig : IEntityTypeConfiguration<DefaultTaxCodeRef>
{
    public void Configure(EntityTypeBuilder<DefaultTaxCodeRef> builder)
    {
        builder.HasKey(p => p.DefaultTaxCodeRefId).HasName("PK_DefaultTaxCodeRef_DefaultTaxCodeRefId");

        builder.Property(x => x.RealmId)
              .IsRequired()
              .HasColumnType("nvarchar")
              .HasMaxLength(255);

        builder.Property(x => x.Name)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Type)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.HasMany<Customer>(h => h.Customers)
               .WithOne(w => w.DefaultTaxCodeRef)
               .HasForeignKey(f => f.DefaultTaxCodeRefId)
               .HasConstraintName("FK_Customer_DefaultTaxCodeRefId");

    }
}
