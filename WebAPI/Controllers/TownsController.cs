using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownsController : ControllerBase
    {
        ITownService _townService;

        public TownsController(ITownService townService)
        {
            _townService = townService;
        }

        [HttpGet("getbycityid")]
        public IActionResult GetByCityId (int cityId)
        {
            var result = _townService.GetByCityId(cityId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
