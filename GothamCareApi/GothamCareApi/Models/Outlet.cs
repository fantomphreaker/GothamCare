using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.Models
{
    public class Outlet
    {
        public int Id { get; set; }
        
        public string OutletName { get; set; }
        public string StreetName { get; set; }
        public string Landmark { get; set; }
        public int TotalAvailableFoodPackets { get; set; }
        public string FoodType { get; set; }
        public int RequiredNoOfVolunteers { get; set; }
        public DateTime Date { get; set; }
    }
}
