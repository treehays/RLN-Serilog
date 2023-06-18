using Microsoft.AspNetCore.Mvc;
using RLN_Serilog.Models;
using System.Diagnostics;

namespace RLN_Serilog.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Requested the Index Page");
        int count;
        try
        {
            for (count = 0; count <= 5; count++)
            {
                if (count == 3)
                {
                    throw new Exception("RandomException");
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception Caught");
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public void OnGet()
    {
        _logger.LogInformation("Requested the Index Page");
        int count;
        try
        {
            for (count = 0; count <= 5; count++)
            {
                if (count == 3)
                {
                    throw new Exception("RandomException");
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception Caught");
        }

    }
}
