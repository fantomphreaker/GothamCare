﻿using GothamCareApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.VolunteerData
{
    public class SqlVolunteerData : IVolunteerData
    {
        private GothamCareApiContext _gothamCareApiContext;
        public SqlVolunteerData(GothamCareApiContext gothamCareApiContext)
        {
            _gothamCareApiContext = gothamCareApiContext;
        }
        public Volunteer AddVolunteer(Volunteer volunteer)
        {
            _gothamCareApiContext.Volunteers.Add(volunteer);
            _gothamCareApiContext.SaveChanges();
            return volunteer;
        }

        public void DeleteVolunteer(Volunteer volunteer)
        {
            throw new NotImplementedException();
        }

        public Volunteer GetVolunteer(int Id)
        {
            var newVolunteer = _gothamCareApiContext.Volunteers.Find(Id);

            return newVolunteer;
        }

        public List<Volunteer> GetVolunteers()
        {
            return _gothamCareApiContext.Volunteers.ToList();
        }

        public Volunteer ModifyVolunteer(Volunteer volunteer)
        {
            throw new NotImplementedException();
        }
    }
}
