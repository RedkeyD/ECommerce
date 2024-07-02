﻿namespace Domain.Entities;
public class OrderItem
{
    public Guid Id { get; }
    public Guid OrderId { get; }
    public Guid ProductId { get; }
    public decimal Quantity { get; }
    public decimal Price { get; }
    public string Currency { get; }
    public Order Order { get; }
    public Product Product { get; }

    public OrderItem( Guid orderId, Guid productId, int quantity, decimal price )
    {
        if ( orderId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( orderId )}' cannot be null " );
        }

        if ( productId == Guid.Empty )
        {
            throw new ArgumentException( $"'{nameof( productId )}' cannot be null " );
        }

        if ( quantity <= 0 )
        {
            throw new ArgumentException( $"'{nameof( quantity )}' must be greater than zero.", nameof( quantity ) );
        }

        if ( price <= 0 )
        {
            throw new ArgumentException( $"'{nameof( price )}' must be greater than zero.", nameof( price ) );
        }

        Id = Guid.NewGuid();
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        Price = price;
    }
}