using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcTemplate
{
    //create HomeController class which is derived from Controller class
    public class HomeController : Controller
    {
        //create Index action
        //by convention and as per the default route setup in the 
        //Startup class Index action on Home controller will be called
        //if no route is specified. 
        //This action will also respond to request for "/home/index" url
        public IActionResult Index()
        {
            ViewBag.Message = "Hello ASP.NET Core";
            return View();
        }
    }
}