using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.VolunteerService
{
     public interface IVolunteerService
    {
        List<Volunteer> GetVolunteers();

        Volunteer GetVolunteer(int Id);

        Volunteer AddVolunteer(Volunteer volunteer);

        Volunteer ModifyVolunteer(Volunteer volunteer);

        void DeleteVolunteer(Volunteer volunteer);

    }
}
