using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace uppfinnaren_1_0_maxie1337.Controllers;


public class HomeController : Controller
{
    public IActionResult Contact()
    {
        return View();
    }
}

