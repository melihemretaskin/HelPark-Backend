using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelParkUser.API.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {

          


            return View();
        }
    }
}
