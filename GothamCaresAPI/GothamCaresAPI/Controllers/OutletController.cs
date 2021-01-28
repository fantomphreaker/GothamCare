using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessService.OutletService;
using DataService.Models;

namespace GothamCaresAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutletController : ControllerBase
    {
        private IOutletService _outletData;

        public OutletController(IOutletService outletData)
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
            if (outlet != null)
            {
                return Ok(outlet);
            }

            return NotFound($"Outlet with id: {Id} was not found! ");

        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddOutlet(Outlet outlet)
        {
            Outlet addedOutlet = _outletData.AddOutlet(outlet);
            if (addedOutlet != null)
            {
                return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + outlet.Id, outlet);
            }

            return NotFound("Cannot add outlets with redundant names having the same dates of opening. ");
        }

        [HttpPatch]
        [Route("api/[controller]/{id:int}")]
        public IActionResult ModifyOutlet(int Id, Outlet outlet)
        {
            var existingOutlet = _outletData.GetOutlet(Id);

            if (existingOutlet != null)
            {
                outlet.Id = existingOutlet.Id;
                _outletData.ModifyOutlet(outlet);

                return Ok(outlet);
            }

            return NotFound($"Outlet with id: {Id} was not found");
        }

        [HttpDelete]
        [Route("api/[controller]/{id:int}")]
        public IActionResult DeleteOutlet(int Id)
        {
            var outlet = _outletData.GetOutlet(Id);

            if (outlet != null)
            {
                _outletData.DeleteOutlet(outlet);

                return Ok();
            }

            return NotFound($"Outlet with Id: {Id} was not found");
        }
    }
}
