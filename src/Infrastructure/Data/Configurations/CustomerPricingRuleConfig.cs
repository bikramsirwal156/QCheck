using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
public class CustomerPricingRuleConfig : IEntityTypeConfiguration<CustomerPricingRule>
{
    public void Configure(EntityTypeBuilder<CustomerPricingRule> builder)
    {
        builder.HasKey(x => x.CustomerPricingRuleId).HasName("PK_CustomerPricingRule_CustomerPricingRuleId");

        builder.Property(x => x.CustomerPricingRuleId)
               .HasColumnType("int")
               .IsRequired()
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.PricingRuleId)
               .IsRequired()
               .HasColumnType("int");

        builder.Property(x => x.CustomerId)
               .IsRequired()
               .HasColumnType("int");

        builder.Property(x => x.ItemId)
              .IsRequired()
              .HasColumnType("int");

        builder.Property(x => x.Price)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.CreatedOn)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.UpdatedOn)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.HasOne(b => b.Customers)
               .WithMany(c => c.CustomerPricingRules)
               .HasForeignKey(c => c.CustomerId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_CustomerPricingRule_CustomerId");

        builder.HasOne(b => b.Item)
              .WithMany(c => c.CustomerPricingRules)
              .HasForeignKey(c => c.CustomerId)
              .OnDelete(DeleteBehavior.Cascade)
              .HasConstraintName("FK_CustomerPricingRule_ItemId");

        builder.HasOne(b => b.PricingRule)
              .WithMany(c => c.CustomerPricingRules)
              .HasForeignKey(c => c.PricingRuleId)
              .OnDelete(DeleteBehavior.Cascade)
              .HasConstraintName("FK_CustomerPricingRule_PricingRuleId");
    }
}
