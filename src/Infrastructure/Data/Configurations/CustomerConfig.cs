using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities;

namespace QCheck.Infrastructure.Data.Configurations;
public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {

        builder.HasKey(x => x.CustomerId).HasName("PK_Customer_CustomerId");
        builder.Property(x => x.CustomerId)
               .HasColumnType("int")
               .IsRequired()
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.RealmId)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Taxable)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.BillAddrId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.ShipAddrId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.Job)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.BillWithParent)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.Balance)
               .IsRequired(false)
               .HasColumnType("decimal(18,6))");

        builder.Property(x => x.BalanceWithJobs)
               .IsRequired(false)
               .HasColumnType("decimal(18,6))");

        builder.Property(x => x.CurrencyRefId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.PreferredDeliveryMethod)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Domain)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Sparse)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.SyncToken)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.CreateTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.LastUpdatedTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.GivenName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.FamilyName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.FullyQualifiedName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.CompanyName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.DisplayName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Id)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.PrintOnCheckName)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Active)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.PrimaryPhone)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.PrimaryEmailAddr)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.DefaultTaxCodeRefId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.WhatsappNumber)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Mobile)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.PersonalNote)
               .IsRequired(false)
               .HasColumnType("nvarchar(max)");

        builder.Property(x => x.DefaultTerritory)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.ShippingPrice)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.ShowInReport)
               .IsRequired(false)
               .HasDefaultValue(true)
               .HasColumnType("bit");

        builder.Property(x => x.IsDisabled)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.HasLoginAccess)
               .IsRequired()
               .HasColumnType("bit");

        builder.Property(x => x.TermId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.ProblematicCustomer)
               .IsRequired(false)
               .HasColumnType("bit");

        builder.Property(x => x.OverdueAmount)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.HasOne(c => c.BillAddr)
               .WithMany(e => e.Customers)
               .HasForeignKey(c => c.BillAddrId)
               .HasConstraintName("FK_Customer_BillAddr");


        builder.HasOne(c => c.CurrencyRef)
               .WithMany(e=>e.Customers)
               .HasForeignKey(c => c.CurrencyRefId)
               .HasConstraintName("FK_Customer_CurrencyRef");

        builder.HasOne(c => c.DefaultTaxCodeRef)
               .WithMany(e=>e.Customers)
               .HasForeignKey(c => c.DefaultTaxCodeRefId)
               .HasConstraintName("FK_Customer_DefaultTaxCodeRef");

        builder.HasOne(c => c.ShipAddr)
               .WithMany(e => e.Customers)
               .HasForeignKey(c => c.ShipAddrId)
               .HasConstraintName("FK_Customer_ShipAddr");

        builder.HasMany(c => c.Estimates)
               .WithOne(e => e.Customers)
               .HasConstraintName("FK_Customer_Estimate");

        builder.HasMany(c => c.Invoices)
               .WithOne(i => i.Customers)
               .HasConstraintName("FK_Customer_Invoice");

        builder.HasMany(c => c.CustomerCreditMemoes)
               .WithOne(ccm => ccm.Customers)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Customer_CustomerCreditMemo");

        builder.HasMany(c => c.Payments)
               .WithOne(p => p.Customers)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Customer_Payment");

        builder.HasMany(c => c.CustomerPricingRules)
               .WithOne(cpr => cpr.Customers)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Customer_CustomerPricingRule");

        builder.HasMany(c => c.ReturnPickups)
               .WithOne(rp => rp.Customers)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Customer_ReturnPickup");

        builder.HasMany(c => c.OrderReceiveds)
               .WithOne(or => or.Customers)
               .HasForeignKey(x=>x.CustomerId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Customer_OrderReceived");

        builder.HasOne(c => c.Term)
               .WithMany(x=>x.Customers)
               .HasForeignKey(c => c.TermId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Customer_Term");
    }
}
