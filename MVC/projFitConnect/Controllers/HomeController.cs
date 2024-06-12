using Microsoft.AspNetCore.Mvc;
using projFitConnect.Models;
using System.Diagnostics;

namespace projFitConnect.Controllers
{
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

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Session()
        {
            string id = HttpContext.Session.GetString("ID");
            string role_id = HttpContext.Session.GetString("role_ID");

            return RedirectToAction("Index");
        }

        public IActionResult Policy()
        {
            //  �A�ȱ��� �ŧR�ŧ�W
            return View();
        }

        public IActionResult Privacy()
        {
            //  ���p�v�F�� �ŧR�ŧ�W
            return View();
        }

        public IActionResult Service()
        {
            //  �h�ڬF�� �ŧR�ŧ�W
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
