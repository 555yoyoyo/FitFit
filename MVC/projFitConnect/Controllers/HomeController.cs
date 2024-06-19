using Microsoft.AspNetCore.Mvc;
using projFitConnect.Models;
using projFitConnect.ViewModels;
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

        public IActionResult Session([FromForm] C_user user)
        {
            if (user != null)
            {
                int id = 0;
                int r_id = 0;
                bool a = int.TryParse(user.id, out id);
                bool b = int.TryParse(user.role_id, out r_id);

                if (a && b)
                {
                    HttpContext.Session.Clear();
                    HttpContext.Session.SetInt32("ID", id);
                    HttpContext.Session.SetInt32("role_ID", r_id);
                }
                //  TODO error msg
                else
                    return RedirectToAction("login", "Home");
            }
            return RedirectToAction("", "Home");
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
