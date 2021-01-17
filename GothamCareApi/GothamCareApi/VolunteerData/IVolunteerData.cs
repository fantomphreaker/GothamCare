using GothamCareApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.VolunteerData
{
    public interface IVolunteerData
    {
        List<Volunteer> GetVolunteers();
        
        Volunteer GetVolunteer(int Id);

        Volunteer AddVolunteer(Volunteer volunteer); //accessed by the person who wants to volunteer

        Volunteer ModifyVolunteer(Volunteer volunteer);

        void DeleteVolunteer(Volunteer volunteer);


    }
}
