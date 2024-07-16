﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Orders
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.HasAlternateKey(o => o.PublicId);

            builder.Property( o => o.UserId ).HasColumnName( nameof( Order.UserId ) ).IsRequired();
            builder.Property( o => o.OrderDate ).HasColumnName( nameof( Order.OrderDate ) ).IsRequired();
            builder.Property( o => o.Status ).HasConversion<int>().HasColumnName( nameof( Order.OrderDate ) ).IsRequired();

            builder
                .HasOne(o => o.User)
                .WithMany(u => u.Orders);

            builder
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);
        }
    }
}