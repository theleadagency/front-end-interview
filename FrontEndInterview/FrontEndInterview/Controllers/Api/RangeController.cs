using FrontEndInterview.Services.Interfaces;
using System.Web.Http;
using System.Linq;
using System.Threading;

namespace FrontEndInterview.Controllers.Api
{
    public class RangeController : ApiController
    {
        private readonly IVehiclesService vehiclesService;

        public RangeController(IVehiclesService vehiclesService)
        {
            this.vehiclesService = vehiclesService;
        }

        [HttpGet]
        public IHttpActionResult GetManufacturerRanges(int manufacturerId)
        {
            Thread.Sleep(2000);
            return this.Ok(vehiclesService.GetRangesByManufacturerId(manufacturerId));
        }
    }
}