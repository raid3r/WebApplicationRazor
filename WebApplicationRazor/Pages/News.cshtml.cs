using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationRazor.Models;

namespace WebApplicationRazor.Pages;

public class NewsModel : PageModel
{
        private List<NewsItem> NewsItems { get; set; } = new List<NewsItem>
        {
            new NewsItem
            {
                Id = 1,
                Title = "Breaking News",
                Content = "This is the content of the breaking news.",
                PublishedDate = DateTime.Now.AddDays(-1)
            },
            new NewsItem
            {
                Id = 2,
                Title = "Latest Updates",
                Content = "Here are the latest updates on our project.",
                PublishedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 3,
                Title = "Tech Innovations",
                Content = "Discover the latest innovations in technology.",
                PublishedDate = DateTime.Now.AddDays(1)
            },
            new NewsItem
            {
                Id = 4,
                Title = "Community News",
                Content = "Join us for the upcoming community event.",
                PublishedDate = DateTime.Now.AddDays(2)
            },
            new NewsItem
            {
                Id = 5,
                Title = "Health and Wellness",
                Content = "Tips for maintaining a healthy lifestyle.",
                PublishedDate = DateTime.Now.AddDays(3)
            }
        };

    //[BindProperty] // GET POST
    public string Search { get; set; } = string.Empty;

    public List<NewsItem> GetNewsItems()
    {
        if (!string.IsNullOrEmpty(Search))
        {
            return NewsItems
                .Where(n => n.Title.Contains(Search, StringComparison.InvariantCultureIgnoreCase) ||
                            n.Content.Contains(Search, StringComparison.InvariantCultureIgnoreCase))
                .ToList();
        }

        return NewsItems;
    }

    // Перші методи які спрацьоють при запиті до сторінки
    public void OnGet()
    {
        Search = Request.Query["Search"]; // GET ?Search=somevalue
    }

    public void OnPost()
    {
        Search = Request.Form["Search"];   // POST              form
    }
}
