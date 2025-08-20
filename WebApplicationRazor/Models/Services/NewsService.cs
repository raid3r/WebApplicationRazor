namespace WebApplicationRazor.Models.Services;

public class NewsService: INewsService
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


    public List<NewsItem> GetNewsItems(string search)
    {
        if (!string.IsNullOrEmpty(search))
        {
            return NewsItems
                .Where(n => n.Title.Contains(search, StringComparison.InvariantCultureIgnoreCase) ||
                            n.Content.Contains(search, StringComparison.InvariantCultureIgnoreCase))
                .ToList();
        }

        return NewsItems;
    }

}
