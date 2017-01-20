using FrontEndInterview.ViewModels;
using System.Web.Mvc;

namespace FrontEndInterview.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Title = "Find your next car here...",
                Testimonial = new Testimonial
                {
                    Comment = "The Lead Agency helped me get a great deal on my new car. I saved £3500 and also got sat nav added for free!",
                    CustomerName = "Mike P, Dorset"
                }
            };

            this.AddNewsSummaries(viewModel);

            return View(viewModel);
        }

        private void AddNewsSummaries(HomeViewModel viewModel)
        {
            viewModel.NewsArticles.Add(new NewsSummaryViewModel
            {
                Title = "BMW release a new 3-series coupe",
                Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean euismod bibendum laoreet.",
                ImageUrl = "/assets/images/news/bmw-release-a new-3-series-coupe.jpg",
                Url = "#BMWNewsLink"
            });

            viewModel.NewsArticles.Add(new NewsSummaryViewModel
            {
                Title = "Audi Q7 Unleashed - see the latest model",
                Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean euismod bibendum laoreet.",
                ImageUrl = "/assets/images/news/audi-q7-unleashed-see-the-latest-model.jpg",
                Url = "#AudiNewsLink"
            });

            viewModel.NewsArticles.Add(new NewsSummaryViewModel
            {
                Title = "Ford Focus Hatchback 2.0ST 5dr - Amazing deal",
                Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean euismod bibendum laoreet.",
                ImageUrl = "/assets/images/news/ford-focus-hatchback-st-amazing-deal.jpg",
                Url = "#FordNewsLink"
            });

            viewModel.NewsArticles.Add(new NewsSummaryViewModel
            {
                Title = "Tesla Model 3 nets 115,000 orders",
                Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean euismod bibendum laoreet.",
                ImageUrl = "/assets/images/news/tesla-model-3-nets-115-000-orders.jpg",
                Url = "#TeslaNewsLink"
            });

            viewModel.NewsArticles.Add(new NewsSummaryViewModel
            {
                Title = "The end of cars is not coming, so bore off already",
                Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean euismod bibendum laoreet.",
                ImageUrl = "/assets/images/news/the-end-of-cars-is-not-coming-so-bore-off-already.jpg",
                Url = "#EndOfCarNewsLink"
            });

            viewModel.NewsArticles.Add(new NewsSummaryViewModel
            {
                Title = "The Ultimate Supermobile Concept Car",
                Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean euismod bibendum laoreet.",
                ImageUrl = "/assets/images/news/ford-focus-hatchback-st-amazing-deal.jpg",
                Url = "#ConceptCarNewsLink"
            });
        }
    }
}