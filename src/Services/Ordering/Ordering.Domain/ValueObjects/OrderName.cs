namespace Ordering.Domain.ValueObjects;

public record class OrderName
{
    private const int DefaultLength = 5;
    public string Value { get; set; }
    private OrderName(string value) => Value = value;

    public static OrderName Of(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        ArgumentOutOfRangeException.ThrowIfEqual(value.Length, DefaultLength);

        return new OrderName(value);
    }
}
