namespace WebApplicationRazor.Models.Services;

public interface INewsService
{
    List<NewsItem> GetNewsItems(string search);
}

