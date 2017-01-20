using System.Web.Mvc;

namespace FrontEndInterview
{
    /// <summary>
    /// The FilterConfig class
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// The RegisterGlobalFilters method
        /// </summary>
        /// <param name="filters">A filters collection</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}