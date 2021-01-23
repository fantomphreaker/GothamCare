using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataService.Models
{
    public class Outlet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Name can't be more than 15 characters!")]
        public string OutletName { get; set; }

        [Required]
        public string StreetName { get; set; }
        
        [Required]
        public string Landmark { get; set; }

        [Required]
        public int TotalAvailableFoodPackets { get; set; }
        
        [Required]
        public FoodType FoodType { get; set; }

        [Required]
        public int RequiredNoOfVolunteers { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}

public enum FoodType
{
    Veg, NonVeg, Both
}
