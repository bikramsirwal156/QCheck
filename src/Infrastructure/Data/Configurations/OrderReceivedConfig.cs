using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class OrderReceivedConfig : IEntityTypeConfiguration<OrderReceived>
{
    public void Configure(EntityTypeBuilder<OrderReceived> builder)
    {
        builder.HasKey(x => x.OrderReceivedId).HasName("Pk_OrderReceived_OrderReceivedId");
        builder.Property(x => x.OrderReceivedId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.CustomerId)
              .IsRequired()
              .HasColumnType("int");

        builder.Property(x => x.IsEstimateCreated)
               .IsRequired()
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.TxnDate)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.Comments)
              .IsRequired(false)
              .HasColumnType("nvarchar(max)");

        builder.Property(x => x.PrivateNotes)
              .IsRequired(false)
              .HasColumnType("nvarchar(max)");

        builder.Property(x => x.OrderStatus)
              .IsRequired(false)
              .HasColumnType("nvarchar")
              .HasMaxLength(255);

        builder.Property(x => x.CreatedOn)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.ModifiedOn)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.HasOne(h => h.Customers)
               .WithMany(w => w.OrderReceiveds)
               .HasForeignKey(f => f.CustomerId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_OrderReceived_CustomerId");
    }
}
