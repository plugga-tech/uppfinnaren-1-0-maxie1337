using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace uppfinnaren_1_0_maxie1337.Controllers;


public class AboutController : Controller
{
    public IActionResult Info()
    {
        return View();
    }
}