using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class BillAddrConfig : IEntityTypeConfiguration<BillAddr>
{
    public void Configure(EntityTypeBuilder<BillAddr> builder)
    {
        builder.HasKey(x => x.BillAddrId).HasName("PK_BillAddr_BillAddrId");
        builder.Property(x => x.BillAddrId)
               .HasColumnType("int")
               .IsRequired()
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

        builder.HasMany<Customer>(b => b.Customers)
         .WithOne(c => c.BillAddr)
         .HasForeignKey(c => c.BillAddrId)
         .OnDelete(DeleteBehavior.Cascade)
         .HasConstraintName("FK_Customer_BillAddr");
    }
}
