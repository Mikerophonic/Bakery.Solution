using System.Collections.Generic;

namespace Bakery.Models
{
 public class Flavor
 {
   public int FlavorId { get; set; }
   public string Description { get; set; }
   public List<FlavorTreat> JoinEntities { get; set; } 
   public ApplicationUser User { get; set; }  

 }
}