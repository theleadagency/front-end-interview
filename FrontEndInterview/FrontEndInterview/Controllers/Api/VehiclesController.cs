using System.Threading;
using FrontEndInterview.Services.Interfaces;
using System.Web.Http;
using System.Linq;

namespace FrontEndInterview.Controllers.Api
{
    /// <summary>
    /// Controller for retrieving Vehicle data.
    /// </summary>
    public class VehiclesController : ApiController
    {
        private readonly IVehiclesService vehiclesService;

        public VehiclesController(IVehiclesService vehiclesService)
        {
            this.vehiclesService = vehiclesService;
        }

        /// <summary>
        /// Get list of manufacturers.
        /// </summary>
        /// <returns>Json list of manufacturers.</returns>
        [HttpGet]
        public IHttpActionResult GetManufacturers()
        {
            Thread.Sleep(2000);

            var manufacturers = this.vehiclesService.GetManufacturers();

            return this.Ok(manufacturers);
        }

        /// <summary>
        /// Get list of models for a given Manufacturer Id.
        /// </summary>
        /// <param name="manufacturerId">The Manufacturer Id.</param>
        /// <returns>Json list of models.</returns>
        [HttpGet]
        public IHttpActionResult GetModelsByManufacuterId(int manufacturerId)
        {
            Thread.Sleep(2000);

            var modelsToReturn = this.vehiclesService.GetRangesByManufacturerId(manufacturerId);

            if(modelsToReturn == null || !modelsToReturn.Any())
            {
                return this.NotFound();
            }

            return this.Ok(modelsToReturn);
        }
    }    
}