using DDDUsingCSharp.Examples.Example2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace DDDUsingCSharp.Examples.Example2.Infrastructure
{


    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.OwnsOne(o => o.ShippingAddress, a =>
            {
                a.Property<int>("OrderId");
                a.WithOwner();
            });
        }
    }
}