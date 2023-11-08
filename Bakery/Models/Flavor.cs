using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
 public class Flavor
 {
   public int FlavorId { get; set; }
   [Required(ErrorMessage = "Please enter a description.")]
   public string Description { get; set; }
   public List<FlavorTreat> JoinEntities { get; set; } 
   public ApplicationUser User { get; set; }  

 }
}