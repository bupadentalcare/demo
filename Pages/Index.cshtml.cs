using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AmazonUkProductSearch.Pages;

public class Product
{
    public string Title { get; set; }
    public string Price { get; set; }
    public string Url { get; set; }
}

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public string SearchTerm { get; set; }
    public List<Product> Results { get; set; }

    public void OnGet()
    {
        // No results on initial load
    }

    public void OnPost()
    {
        // Mocked product results for demonstration
        Results = new List<Product>
        {
            new Product { Title = $"{SearchTerm} - Example Product 1", Price = "£19.99", Url = "https://www.amazon.co.uk/dp/example1" },
            new Product { Title = $"{SearchTerm} - Example Product 2", Price = "£29.99", Url = "https://www.amazon.co.uk/dp/example2" },
            new Product { Title = $"{SearchTerm} - Example Product 3", Price = "£39.99", Url = "https://www.amazon.co.uk/dp/example3" }
        };
    }
}
