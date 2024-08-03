namespace Ordering.Domain.ValueObjects;

public class Payment
{
    public string? CardName { get; } = default!;
    public string? CardNumber { get; } = default!;
    public string? Expiration { get; } = default!;
    public string? CVV { get; } = default!;
    public string? PaymentMethod { get; } = default!;
}