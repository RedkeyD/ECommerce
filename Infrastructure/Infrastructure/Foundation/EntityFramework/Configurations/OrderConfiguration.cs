﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Foundation.EntityFramework.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure( EntityTypeBuilder<Order> builder )
        {
            builder.HasKey( o => o.Id );

            builder
                .HasOne( o => o.User )
                .WithMany( u => u.Orders );

            builder
                .HasMany( o => o.OrderItems )
                .WithOne( oi => oi.Order )
                .HasForeignKey( oi => oi.OrderId );
        }
    }
}