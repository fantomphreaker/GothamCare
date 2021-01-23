using BusinessService.VolunteerService;
using DataService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCaresAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {
        private IVolunteerService _volunteerService;
        public VolunteerController(IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetVolunteers()
        {
            return Ok(_volunteerService.GetVolunteers());
        }

        [HttpGet]
        [Route("api/[controller]/{id:int}")]
        public IActionResult GetVolunteer(int Id)
        {
            var volunteer = _volunteerService.GetVolunteer(Id);

            if (volunteer != null)
            {
                return Ok(volunteer);
            }

            return NotFound($"Volunteer with ID: {Id} is not found.");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddVolunteer(Volunteer volunteer)
        {
            _volunteerService.AddVolunteer(volunteer);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + volunteer.Id, volunteer);
        }

        [HttpPatch]
        [Route("api/[controller]/{id:int}")]
        public IActionResult ModifyVolunteer(int Id, Volunteer volunteer)
        {
            var newVolunteer = _volunteerService.GetVolunteer(Id);

            if (newVolunteer != null)
            {
                volunteer.Id = Id;
                _volunteerService.ModifyVolunteer(volunteer);
                return Ok(volunteer);
            }

            return NotFound($"Volunteer with ID: {Id} cannot be found.");
        }

        [HttpDelete]
        [Route("api/[controller]/{id:int}")]
        public IActionResult DeleteVolunteer(int Id)
        {
            var newVolunteer = _volunteerService.GetVolunteer(Id);
            if (newVolunteer != null)
            {
                _volunteerService.DeleteVolunteer(newVolunteer);
                return Ok();
            }

            return NotFound($"Volunteer with ID: {Id} cannot be found.");
        }
    }
}
