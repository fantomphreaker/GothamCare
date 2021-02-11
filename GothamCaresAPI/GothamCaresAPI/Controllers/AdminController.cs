using BusinessService.AdminService;
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
    public class AdminController : ControllerBase
    {
        private IAdminService _adminData;

        public AdminController(IAdminService adminData)
        {
            _adminData = adminData;
        }

        [HttpGet("Login/{email}/{password}")]
        public IActionResult Login(string email, String password)
        {
            Admin admin = _adminData.Login(email, password);
            if (admin == null)
            {
                return NotFound("{\"response\":\"Incorrect Email Address\"}");
            }
            else if (!(admin.Password).Equals(password))
            {
                return NotFound("{\"response\":\"Incorrect Password\"}");
            }
            else
            {
                return Ok("{\"response\":\"Login Success\"}");
            }


        }

    }
}
