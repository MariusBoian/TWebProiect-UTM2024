using System.Web.Mvc;

namespace CTF_Platform.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "QWERTY CTF is a (Capture The Flag) Platform that provide tasks to practice and lear cybersecyrity and penetration testing.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}