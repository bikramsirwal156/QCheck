using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QCheck.Domain.Entities.DoneTable;

namespace QCheck.Infrastructure.Data.Configurations;
internal class InvoiceConfig : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.HasKey(e => e.InvoiceId).HasName("PK_Invoice_InvoiceId");
        builder.Property(e => e.InvoiceId)
               .IsRequired()
               .HasColumnType("int")
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        builder.Property(x => x.RealmId)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(255);


        builder.Property(x => x.Deposit)
               .IsRequired()
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.AllowIPNPayment)
               .IsRequired()
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.AllowOnlinePayment)
              .IsRequired()
              .HasDefaultValue(false)
              .HasColumnType("bit");

        builder.Property(x => x.AllowOnlineACHPayment)
              .IsRequired()
              .HasDefaultValue(false)
              .HasColumnType("bit");

        builder.Property(x => x.AllowOnlineCreditCardPayment)
              .IsRequired()
              .HasDefaultValue(false)
              .HasColumnType("bit");

        builder.Property(x => x.Domain)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Sparse)
               .IsRequired()
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.Id)
               .IsRequired()
               .HasColumnType("int");

        builder.Property(x => x.SyncToken)
               .IsRequired()
               .HasColumnType("int");

        builder.Property(x => x.CreateTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.LastUpdatedTime)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.CustomFieldId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.DocNumber)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.TxnDate)
               .IsRequired()
               .HasColumnType("datetime");

        builder.Property(x => x.CurrencyRefId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.CustomerId)
               .IsRequired(false)
               .HasColumnType("int");


        builder.Property(x => x.CustomerMemo)
               .IsRequired(false)
               .HasColumnType("nvarchar(max)");

        builder.Property(x => x.BillAddrId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.ShipAddrId)
               .IsRequired(false)
               .HasColumnType("int");

        builder.Property(x => x.FreeFormAddress)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.SalesTermRefvalue)
               .IsRequired()
               .HasColumnType("int");


        builder.Property(x => x.DueDate)
               .IsRequired(false)
               .HasColumnType("datetime");

        builder.Property(x => x.TotalAmt)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.ApplyTaxAfterDiscount)
               .IsRequired(false)
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.PrintStatus)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.EmailStatus)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.BillEmailAddress)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.Balance)
               .IsRequired(false)
               .HasColumnType("decimal(18,6)");

        builder.Property(x => x.PrivateNote)
               .IsRequired(false)
               .HasColumnType("nvarchar")
               .HasMaxLength(255);

        builder.Property(x => x.DeliveryInfoDeliveryType)
              .IsRequired(false)
              .HasColumnType("nvarchar")
              .HasMaxLength(255);

        builder.Property(x => x.IsDispatchRoute)
               .IsRequired()
               .HasDefaultValue(false)
               .HasColumnType("bit");

        builder.Property(x => x.DispatchedDate)
             .IsRequired()
             .HasColumnType("datetime");

        builder.Property(x => x.Comment)
              .IsRequired(false)
              .HasColumnType("nvarchar(max)");

        builder.Property(x => x.Stop)
               .IsRequired()
               .HasColumnType("int");

        builder.Property(x => x.ShippingCompany)
              .IsRequired(false)
              .HasColumnType("nvarchar(max)");

        builder.Property(x => x.Driver)
              .IsRequired(false)
              .HasColumnType("nvarchar(max)");

        builder.Property(x => x.AssignedTo)
             .IsRequired(false)
             .HasColumnType("nvarchar");

        builder.HasMany(c => c.EstimateInvoiceStaggings)
               .WithOne(e => e.Invoice)
               .HasForeignKey(c => c.InvoiceId)
               .HasConstraintName("FK_EstimateInvoiceStagging_Invoice");

        builder.HasOne(c => c.BillAddr)
               .WithMany()
               .HasForeignKey(c => c.BillAddrId)
               .HasConstraintName("FK_Invoice_BillAddrId");

        builder.HasOne(e => e.CurrencyRefs)
               .WithMany(x => x.Invoices)
               .HasForeignKey(e => e.CurrencyRefId)
               .HasConstraintName("FK_Invoice_CurrencyRefId");

        builder.HasOne(e => e.Customers)
               .WithMany(x => x.Invoices)
               .HasForeignKey(e => e.CustomerId)
               .HasConstraintName("FK_Invoice_CustomerId"); ;

        builder.HasOne(e => e.CustomField)
               .WithMany(x => x.Invoices)
               .HasForeignKey(e => e.CustomFieldId)
               .HasConstraintName("FK_Invoice_CustomFieldId"); ;

        builder.HasOne(e => e.ShipAddr)
               .WithMany(x => x.Invoices)
               .HasForeignKey(e => e.ShipAddrId)
               .HasConstraintName("FK_Invoice_ShipAddrId");
    }
}
