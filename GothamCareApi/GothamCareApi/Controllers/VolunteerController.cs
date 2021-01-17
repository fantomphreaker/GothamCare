using GothamCareApi.Models;
using GothamCareApi.VolunteerData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {
        private IVolunteerData _volunteerData;

        public VolunteerController(IVolunteerData volunteerData)
        {
            _volunteerData = volunteerData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetVolunteers()
        {
            return Ok(_volunteerData.GetVolunteers());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetVolunteer(int Id)
        {
            var volunteer = _volunteerData.GetVolunteer(Id);
            
            if(volunteer != null)
            {
                return Ok(volunteer);
            }

            return NotFound($"Volunteer with ID: {Id} is not found.");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddVolunteer(Volunteer volunteer)
        {
            _volunteerData.AddVolunteer(volunteer);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + volunteer.Id, volunteer);
        }
    }
}
