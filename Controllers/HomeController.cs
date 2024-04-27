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

    public IActionResult ListaUsers2() { 
        string ConnectionString = "Data Source=tcp:DESKTOP-JQA6K8K,49172;Initial Catalog=LAB12AD;Persist Security Info=True;User ID=LABUSER;Password=LAB12;Encrypt=False;Trust Server Certificate=True";
        
        SqlConnection con = new SqlConnection(ConnectionString);

        con.Open();

        string query = "select pl.username, rg.name, sk.name from PLAYERUSER pl\r\n\tinner join INVENTORY iv\r\n\t\ton pl.Id_PlayerUser = iv.Id_PlayerUser\r\n\tinner join COSMETIC cs\r\n\t\ton cs.Id_Inventory = iv.Id_Inventory\r\n\tinner join SKIN sk\r\n\t\ton sk.Id_Skin = cs.Id_Skin\r\n\tinner join REGION rg\r\n\t\ton rg.Id_Region = pl.Id_Region";
        
        SqlCommand cmd = new SqlCommand(query, con);

        var result = cmd.ExecuteReader();

        List<Player> resultList = new List<Player>();
        while (result.Read())
        {
            Player entity = new Player();
            entity.username = (string)result["username"];
            entity.region = (string)result["name"];
            entity.skin = (string)result["name"];
            // ...
            //
            resultList.Add(entity);
        }

        return View(resultList);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
