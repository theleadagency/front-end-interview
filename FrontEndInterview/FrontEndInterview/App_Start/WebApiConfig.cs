using System.Web.Http;

namespace FrontEndInterview
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "ManufacturerRoute",
                routeTemplate: "api/manufacturers/{manufacturerId}",
                defaults: new { controller = "Manufacturer", manufacturerId = RouteParameter.Optional }
                );

            config.Routes.MapHttpRoute(
                name: "RangeRoute",
                routeTemplate: "api/manufacturers/{manufacturerId}/ranges",
                defaults: new { controller = "Range"}
                );

            config.Routes.MapHttpRoute(
                name: "OfferRoute",
                routeTemplate: "api/manufacturers/{manufacturerId}/ranges/{rangeId}/offers",
                defaults: new { controller = "Offer"  }
                );
        }
    }
}