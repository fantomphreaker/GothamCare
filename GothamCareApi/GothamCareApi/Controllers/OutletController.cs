using GothamCareApi.Models;
using GothamCareApi.OutletData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutletController : ControllerBase
    {
        private IOutletData _outletData;

        public OutletController(IOutletData outletData)
        {
            _outletData = outletData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetOutlets()
        {
            return Ok(_outletData.GetOutlets());
        }

        [HttpGet]
        [Route("api/[controller]/{id:int}")]
        public IActionResult GetOutlet(int Id)
        {
            var outlet = _outletData.GetOutlet(Id);
            if(outlet != null)
            {
                return Ok(outlet);
            }

            return NotFound($"Outlet with id: {Id} was not found! ");

        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetOutlet(Outlet outlet)
        {
            _outletData.AddOutlet(outlet);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + outlet.Id, outlet);
        }

        [HttpPatch]
        [Route("api/[controller]/{id:int}")]
        public IActionResult ModifyOutlet(int Id, Outlet outlet)
        {
            var existingOutlet = _outletData.GetOutlet(Id);
            
            if(existingOutlet != null)
            {
                outlet.Id = existingOutlet.Id;
                _outletData.ModifyOutlet(outlet);

                return Ok(outlet);
            }

            return NotFound($"Outlet with id: {Id} was not found");
        }
    }
}
