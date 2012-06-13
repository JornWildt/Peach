using System.Web.Mvc;


namespace Peach.Profiles.Web.Areas.Profiles.Controllers
{
  public class profileController : Controller
  {
    [HttpGet]
    public ActionResult show(string profilename)
    {
      return View();
    }
  }
}
