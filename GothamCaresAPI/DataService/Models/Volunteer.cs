using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataService.Models
{
    public class Volunteer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string VolunteerName { get; set; }
        
        [Required]
        public string VolunteerAddress { get; set; }
        
        [Required]
        public string VolunteerPhoneNumber { get; set; }

        [Required]
        public DateTime VolunteerDate { get; set; }
        

        [ForeignKey("Outlet")]
        public int OutletID { get; set; }

        public Outlet Outlet { get; set; }
    }
}
