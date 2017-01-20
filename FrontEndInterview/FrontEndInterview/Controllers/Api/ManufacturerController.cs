using FrontEndInterview.Services.Interfaces;
using System.Web.Http;
using System.Linq;

namespace FrontEndInterview.Controllers.Api
{
    public class ManufacturerController : ApiController
    {
        private readonly IVehiclesService vehiclesService;

        public ManufacturerController(IVehiclesService vehiclesService)
        {
            this.vehiclesService = vehiclesService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return this.Ok(this.vehiclesService.GetManufacturers());
        }

        [HttpGet]
        public IHttpActionResult Get(int manufacturerId)
        {
            var manufacturer = this.vehiclesService.GetManufacturers().SingleOrDefault(o => o.Id == manufacturerId);

            return this.Ok(manufacturer);
        }
    }
}