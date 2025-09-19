namespace RealEstate.Domain;

public class Property
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public PropertyType Type { get; set; }
    public PropertyStatus Status { get; set; }
    public string Address { get; set; } = string.Empty;
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public double Area { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string AgentName { get; set; } = string.Empty;
    public string AgentPhone { get; set; } = string.Empty;
}

public enum PropertyType
{
    Apartment = 1,
    House = 2,
    Villa = 3
}

public enum PropertyStatus
{
    ForSale = 1,
    ForRent = 2,
    Sold = 3,
    Rented = 4
}
