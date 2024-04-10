using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class CurrencyRefConfig : IEntityTypeConfiguration<CurrencyRef>
{
    public void Configure(EntityTypeBuilder<CurrencyRef> builder)
    {
        builder.HasKey(x => x.CurrencyRefId).HasName("Pk_CurrencyRef_CurrencyRefId");
        builder.Property(x => x.CurrencyRefId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

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
            .WithOne(w => w.CurrencyRef)
            .HasForeignKey(f => f.CurrencyRefId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Customers_CurrencyRefId");

        builder.HasMany<Estimate>(h => h.Estimates)
            .WithOne(w => w.CurrencyRefs)
            .HasForeignKey(f => f.CurrencyRefId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Estimate_CurrencyRefId");

        builder.HasMany<Invoice>(h => h.Invoices)
               .WithOne(w => w.CurrencyRefs)
               .HasForeignKey(f => f.CurrencyRefId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Invoice_CurrencyRefId");

    }
}
