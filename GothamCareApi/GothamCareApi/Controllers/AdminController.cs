using GothamCareApi.AdminData;
using GothamCareApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminData _adminData;
        public AdminController(IAdminData adminData)
        {
            _adminData = adminData;
        }

        [HttpGet]
        [Route("api/[controller]/{emailId}")]
        public IActionResult GetAdmin(string emailId)
        {
            var admin = _adminData.GetAdmin(emailId);
            if(admin != null)
            {
                return Ok();
            }

            return NotFound($"Email {emailId} not found.");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminData.AddAdmin(admin);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + admin.EmailId, admin);
        }

        [HttpDelete]
        [Route("api/[controller]/{email}")]
        public IActionResult DeleteAdmin(string email)
        {
            var _admin = _adminData.GetAdmin(email);
            if (_admin != null)
            {
                _adminData.DeleteAdmin(_admin);
                return Ok();
            }

            return NotFound($"Volunteer with ID: {email} cannot be found.");
        }
    }
}
