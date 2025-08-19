using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationRazor.Models;

namespace WebApplicationRazor.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string Message => "Hello, World!";

    public string GetCurrentTime()
    {
        return DateTime.Now.ToString("F");
    }

    public AboutMeInfo GetInfoAboutMe()
    {
        // ”€вимо, що ц€ ≥нформац≥€ отримуЇтьс€ з бази даних або ≥ншого джерела

        return new AboutMeInfo
        {
            Name = "John Doe",
            Bio = "A passionate developer with a love for coding and technology.",
            Interests = "Coding, Reading, Traveling",
            ContactEmail = "test@test.com"
        };
    }

    public void OnGet()
    {

    }
}
