using FrontEndInterview.Services.Interfaces;
using System.Linq;
using System.Collections.Generic;
using FrontEndInterview.Models;

namespace FrontEndInterview.Services
{
    public class VehiclesService : IVehiclesService
    {
        #region Private Fields

        private readonly IEnumerable<Manufacturer> manufacturers = new List<Manufacturer>
            {
                new Manufacturer
                {
                    Id = 1,
                    Name = "Ford"
                },
                new Manufacturer
                {
                    Id = 2,
                    Name = "Audi"
                }
            };

        private readonly IEnumerable<Range> ranges = new List<Range>
            {
                new Range
                {
                    Id = 1,
                    Name = "Focus",
                    ManufacturerId = 1
                },
                new Range
                {
                    Id = 2,
                    Name = "Mondeo",
                    ManufacturerId = 1
                },
                new Range
                {
                    Id = 3,
                    Name = "A1",
                    ManufacturerId = 2
                },
                new Range
                {
                    Id = 4,
                    Name = "A6",
                    ManufacturerId = 2
                }
            };

        private readonly IEnumerable<Offer> offers = new List<Offer>
            {
                new Offer
                {
                    Title = "Ford Focus Deal",
                    ImageUrl = "/assets/images/vehicles/ford-focus.jpg",
                    Price = 15995,
                    Saving = 3500,
                    Url = "#FordFocusDeal",
                    RangeId = 1
                },
                new Offer
                {
                    Title = "Ford Mondeo Deal",
                    ImageUrl = "/assets/images/vehicles/ford-mondeo.jpg",
                    Price = 19995,
                    Saving = 4200,
                    Url = "#FordMondeoDeal",
                    RangeId = 2
                },
                new Offer
                {
                    Title = "Audi A1 Deal",
                    ImageUrl = "/assets/images/vehicles/audi-a1.jpg",
                    Price = 14530,
                    Saving = 2761,
                    Url = "#AudiA1Deal",
                    RangeId = 3
                }
                // Intentionally omitted out the A6 for zero result handling.
            };

        #endregion Private Fields

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            return this.manufacturers;
        }

        public IEnumerable<Range> GetRanges()
        {
            return this.ranges;
        }

        public IEnumerable<Range> GetRangesByManufacturerId(int manufacturerId)
        {
            return this.ranges.Where(o => o.ManufacturerId == manufacturerId);
        }

        public IEnumerable<Offer> GetRangeOffers(int rangeId)
        {
            var offers = this.offers.Where(o => o.RangeId == rangeId);
            return offers;
        }
    }
}