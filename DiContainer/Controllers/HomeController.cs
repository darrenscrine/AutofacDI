using System.Web.Mvc;
using Data;

namespace DiContainer.Controllers
{
    public class HomeController : Controller
    {
        private IRepository Repository { get; set; }

        public HomeController(IRepository repository)
        {
            Repository = repository;
        }

        public ActionResult Index()
        {
            
            Repository.Load();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}