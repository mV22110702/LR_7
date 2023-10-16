using LR_7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace LR_7.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("DownloadFile","File");
        }
    }
}