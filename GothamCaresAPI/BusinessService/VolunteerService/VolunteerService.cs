using DataService;
using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.VolunteerService
{
    public class VolunteerService : IVolunteerService
    {
        private GothamCaresApiContext _gothamCaresApiContext;
        public VolunteerService(GothamCaresApiContext gothamCareApiContext)
        {
            _gothamCaresApiContext = gothamCareApiContext;
        }
        public Volunteer AddVolunteer(Volunteer volunteer)
        {
            _gothamCaresApiContext.Volunteers.Add(volunteer);
            _gothamCaresApiContext.SaveChanges();
            return volunteer;
        }

        public void DeleteVolunteer(Volunteer volunteer)
        {
            _gothamCaresApiContext.Volunteers.Remove(volunteer);
            _gothamCaresApiContext.SaveChanges();
        }

        public Volunteer GetVolunteer(int Id)
        {
            var newVolunteer = _gothamCaresApiContext.Volunteers.Find(Id);

            return newVolunteer;
        }

        public List<Volunteer> GetVolunteers()
        {
            return _gothamCaresApiContext.Volunteers.ToList();
        }

        public Volunteer ModifyVolunteer(Volunteer volunteer)
        {
            var id = volunteer.Id;
            var oldVolunteer = _gothamCaresApiContext.Volunteers.Find(id);
            _gothamCaresApiContext.Volunteers.Remove(oldVolunteer);
            _gothamCaresApiContext.Volunteers.Add(volunteer);
            _gothamCaresApiContext.SaveChanges();

            return volunteer;

        }
    }
}
