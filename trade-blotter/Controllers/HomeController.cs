using System.Web.Mvc;

namespace trade_blotter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Trade Blotter Index.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult User() {
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}