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

    }
}
