using System.Collections.Generic;

namespace FrontEndInterview.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            this.NewsArticles = new List<NewsSummaryViewModel>();
        }

        public string Title { get; set; }

        public Testimonial Testimonial { get; set; }

        public List<NewsSummaryViewModel> NewsArticles { get; set; }
    }

    public class NewsSummaryViewModel
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
    }

    public class Testimonial
    {
        public string Comment { get; set; }
        public string CustomerName { get; set; }
    }
}