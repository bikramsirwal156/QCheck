using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class TermConfig : IEntityTypeConfiguration<Term>
{
    public void Configure(EntityTypeBuilder<Term> builder)
    {
        builder.HasKey(e => e.TermId).HasName("PK_Term_TermId");
        builder.Property(e => e.TermId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.SyncToken)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.Domain)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Name)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.DiscountDays)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.DiscountPercent)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.Sparse)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.Active)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.DueDays)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.Id)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.CreatedOn)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.UpdatedOn)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.HasMany(c => c.Customers)
               .WithOne(x => x.Term)
               .HasForeignKey(c => c.CustomerId)
               .HasConstraintName("FK_Term_CustomerId");
    }
}
