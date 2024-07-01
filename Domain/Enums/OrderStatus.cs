namespace Domain.Enums;

public enum OrderStatus
{
    Created,
    PendingPayment,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}