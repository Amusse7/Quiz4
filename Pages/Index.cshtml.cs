using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Quiz4.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public string? DatabaseMessage { get; set; }

    public void OnGet()
    {
        DatabaseMessage = "Database Access has already been done on Nov 28, 2024, By Abdulkadir Musse";
    }
}
