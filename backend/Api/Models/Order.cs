public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string ClientName { get; set; } = default!;
    public string Product { get; set; } = default!;
    public decimal Value { get; set; }
    public string Status { get; set; } = "Pending"; 
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
}