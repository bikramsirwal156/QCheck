using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class ShipAddrConfig : IEntityTypeConfiguration<ShipAddr>
{
    public void Configure(EntityTypeBuilder<ShipAddr> builder)
    {
        builder.HasKey(p => p.ShipAddrId).HasName("PK_ShipAddr_ShipAddrId");
        builder.Property(p => p.ShipAddrId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.RealmId)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(255);


        builder.Property(x => x.Id)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.Line1)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Line2)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Line3)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Line4)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Line5)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.City)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Country)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.CountryCode)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.CountryCode)
              .IsRequired(false)
              .HasColumnType("nvarchar")
              .HasMaxLength(255);

        builder.Property(x => x.CountrySubDivisionCode)
              .IsRequired(false)
              .HasColumnType("nvarchar")
              .HasMaxLength(255);

        builder.Property(x => x.PostalCode)
              .IsRequired(false)
              .HasColumnType("nvarchar")
              .HasMaxLength(255);

        builder.Property(x => x.PostalCodeSuffix)
             .IsRequired(false)
             .HasColumnType("nvarchar")
             .HasMaxLength(255);

        builder.Property(x => x.Lat)
             .IsRequired(false)
             .HasColumnType("nvarchar")
             .HasMaxLength(255);

        builder.Property(x => x.Long)
            .IsRequired(false)
            .HasColumnType("nvarchar")
            .HasMaxLength(255);

        builder.Property(x => x.Tag)
            .IsRequired(false)
            .HasColumnType("nvarchar")
            .HasMaxLength(255);

        builder.Property(x => x.Note)
            .IsRequired(false)
            .HasColumnType("nvarchar")
            .HasMaxLength(255);

        builder.HasMany<Customer>(h => h.Customers)
               .WithOne(w => w.ShipAddr)
               .HasForeignKey(x => x.ShipAddrId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Customer_ShipAddrId");


        builder.HasMany<Estimate>(h => h.Estimates)
               .WithOne(w => w.ShipAddr)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Estimate_ShipAddrId");

        builder.HasMany<Invoice>(h => h.Invoices)
               .WithOne(w => w.ShipAddr)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey(x => x.ShipAddrId)
               .HasConstraintName("FK_Invoice_ShipAddrId"); ;

        builder.HasMany<CustomerCreditMemo>(h => h.CustomerCreditMemoes)
               .WithOne(w => w.ShipAddr)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey(x => x.ShipAddrId)
               .HasConstraintName("FK_CustomerCreditMemo_ShipAddrId"); ;
    }
}
