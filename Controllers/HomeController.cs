using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LAB12.Models;
using Microsoft.Data.SqlClient;

namespace LAB12.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult GameMain()
    {
        return View();
    }

    public IActionResult GameChat()
    {
        return View();
    }

    public IActionResult Tienda()
    {
        return View();
    }

    public IActionResult ListUsers()
    {
        return View();
    }

    public IActionResult ListUsers2() { 
        string ConnectionString = "Data Source=tcp:DESKTOP-JQA6K8K,49172;Initial Catalog=LAB12AD;Persist Security Info=True;User ID=LABUSER;Password=LAB12;Encrypt=False;Trust Server Certificate=True";
        
        SqlConnection con = new SqlConnection(ConnectionString);

        con.Open();

        string query = "";
        
        SqlCommand cmd = new SqlCommand(query, con);

        var result = cmd.ExecuteReader();
        
        return View(result);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
