using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.Models
{
    public class Volunteer
    {   
        [Key]
        public int Id { get; set; }
        
        public string VolunteerName { get; set; }
        public string VolunteerAddress { get; set; }
        public string VolunteerPhoneNumber { get; set; }
        public DateTime VolunteerDate { get; set; }
        public int OutletID { get; set; }


    }
}
