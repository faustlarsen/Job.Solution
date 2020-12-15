using Microsoft.AspNetCore.Mvc;

namespace JobOffer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}