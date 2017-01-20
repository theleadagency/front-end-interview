using FrontEndInterview.Services.Interfaces;
using System.Web.Http;
using System.Linq;

namespace FrontEndInterview.Controllers.Api
{
    public class OfferController : ApiController
    {
        private readonly IVehiclesService vehiclesService;

        public OfferController(IVehiclesService vehiclesService)
        {
            this.vehiclesService = vehiclesService;
        }

        [HttpGet]
        public IHttpActionResult GetRangeOffers(int manufacturerId, int rangeId)
        {
            var manufacturer = this.vehiclesService.GetManufacturers()
                .Where(o => o.Id == manufacturerId)
                .SingleOrDefault();

            if(manufacturer == null)
            {
                return this.NotFound();
            }

            var range = this.vehiclesService.GetRanges()
                .Where(o => o.ManufacturerId == manufacturer.Id && o.Id == rangeId)
                .SingleOrDefault();

            if(range == null)
            {
                return this.NotFound();
            }

            var offers = vehiclesService.GetRangeOffers(rangeId);

            return this.Ok(offers);
        }
    }
}