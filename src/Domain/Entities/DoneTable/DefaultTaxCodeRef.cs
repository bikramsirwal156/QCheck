﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
namespace QCheck.Domain.QCheck.Domain.Entities;

public partial class DefaultTaxCodeRef
{
    public DefaultTaxCodeRef()
    {
        Customers = new HashSet<Customer>();
    }
    public int DefaultTaxCodeRefId { get; set; }
    public string RealmId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public virtual ICollection<Customer> Customers { get; set; }
}
