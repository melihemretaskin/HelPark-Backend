using System.Collections.Generic;
using HelPark.Business.Interfaces;
using HelPark.Models.IsParkDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelParkUser.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IsParkController : ControllerBase
    {
        private readonly IIsParkService isParkService;

        public IsParkController(IIsParkService isParkService)
        {
            this.isParkService = isParkService;
        }

        //https://localhost:5001/IsPark/GetIsPark
        [HttpGet("GetIsPark")]
        public ActionResult<List<IsPark>> GetIsPark()
        {
            return isParkService.GetIsPark();
        }

        //https://localhost:5001/IsPark/GetIsParkDetail?id=1879
        [HttpGet("GetIsParkDetail")]
        public ActionResult<IsParkDetail> GetIsParkDetail([FromQuery] int id)
        {
            return isParkService.GetIsParkDetailById(id);
        }
    }
}
