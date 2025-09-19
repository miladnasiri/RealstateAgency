using Microsoft.EntityFrameworkCore;
using RealEstate.Domain;

namespace RealEstate.Infrastructure.Data;

public class RealEstateContext : DbContext
{
    public RealEstateContext(DbContextOptions<RealEstateContext> options) : base(options) { }

    public DbSet<Property> Properties { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Property>().HasData(
            new Property
            {
                Id = 1,
                Title = "Modern Apartment in Downtown",
                Description = "Beautiful 2-bedroom apartment with city view",
                Price = 250000,
                Type = PropertyType.Apartment,
                Status = PropertyStatus.ForSale,
                Address = "123 Main Street, Downtown",
                Bedrooms = 2,
                Bathrooms = 2,
                Area = 85.5,
                AgentName = "John Smith",
                AgentPhone = "+1-555-0123"
            },
            new Property
            {
                Id = 2,
                Title = "Cozy Villa with Garden",
                Description = "Spacious villa with private garden and pool",
                Price = 1500,
                Type = PropertyType.Villa,
                Status = PropertyStatus.ForRent,
                Address = "456 Oak Avenue, Suburbs",
                Bedrooms = 4,
                Bathrooms = 3,
                Area = 220.0,
                AgentName = "Sarah Johnson",
                AgentPhone = "+1-555-0124"
            }
        );
    }
}
