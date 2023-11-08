using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Bakery.Models
{
 public class Treat
 {
   public int TreatId { get; set; }
   [Required(ErrorMessage = "Please enter a name.")]
   public string Name { get; set; }
   public List<FlavorTreat> JoinEntities { get; set; } 
   public ApplicationUser User { get; set; }  

 }
}