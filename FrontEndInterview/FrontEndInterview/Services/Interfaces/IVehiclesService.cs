using FrontEndInterview.Models;
using System.Collections.Generic;

namespace FrontEndInterview.Services.Interfaces
{
    public interface IVehiclesService
    {
        IEnumerable<Manufacturer> GetManufacturers();

        IEnumerable<Range> GetRanges();

        IEnumerable<Range> GetRangesByManufacturerId(int manufacturerId);

        IEnumerable<Offer> GetRangeOffers(int rangeId);
    }
}
