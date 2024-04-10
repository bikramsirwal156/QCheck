using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class PaymentConfig : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {

        builder.HasKey(e => e.PaymentId).HasName("PK_Payment_PaymentId");
        builder.Property(e => e.PaymentId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.SyncToken)
              .IsRequired()
              .HasColumnType("int");

        builder.Property(x => x.RealmId)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Domain)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.DepositToAccountValue)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.UnappliedAmt)
              .IsRequired(false)
              .HasColumnType("decimal(18,6)");

        builder.Property(x => x.TxnDate)
             .IsRequired()
             .HasColumnType("datetime");

        builder.Property(x => x.TotalAmt)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.ProcessPayment)
            .IsRequired(false)
            .HasDefaultValue(false)
            .HasColumnType("bit");

        builder.Property(x => x.Sparse)
           .IsRequired(false)
           .HasDefaultValue(false)
           .HasColumnType("bit");

        builder.Property(x => x.Id)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.CreateTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.LastUpdatedTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.CustomerId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.PaymentMethod)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.PaymentRefNum)
               .IsRequired(false)
               .HasColumnType("nvarchar(max)");

        builder.Property(x => x.PrivateNote)
              .IsRequired(false)
              .HasColumnType("nvarchar(max)");

        builder.HasOne(c => c.Customers)
               .WithMany(x => x.Payments)
               .HasForeignKey(c => c.PaymentId)
               .HasConstraintName("FK_Payment_PaymentId");
    }
}
