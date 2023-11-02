namespace Bakery.Models
{
  public class FlavorTreat
  {
    public int FlavorTreatId { get; set; } // Primary Key
    public int FlavorId { get; set; } // Foreign Key to the Flavors table
    public Flavor Flavor { get; set; } // Navigation Property for an Flavor
    public int TreatId { get; set; } // Foreign Key to the Treats table
    public Treat Treat { get; set; } // Navigation Property for a Treat
  }
}