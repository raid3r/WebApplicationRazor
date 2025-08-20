using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationRazor.Models;
using WebApplicationRazor.Models.Services;

namespace WebApplicationRazor.Pages;

public class NewsModel : PageModel
{
    private readonly INewsService _newsService;

    public NewsModel(INewsService newsService)
    {
        _newsService = newsService;
    }

    //[BindProperty] // GET POST
    public string Search { get; set; } = string.Empty;
        

    public List<NewsItem> GetNewsItems()
    {
        return _newsService.GetNewsItems(Search);
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


