using System.Web.Mvc;
using P = Peach.Profiles.Query.Profiles;
using Peach.Profiles.Web.Areas.Profiles.Models;


namespace Peach.Profiles.Web.Areas.Profiles.Controllers
{
  public class profileController : Controller
  {
    [HttpGet]
    public ActionResult show(string profilename)
    {
      P.Profile p = ProfileProvider.GetByProfileName(profilename);

      ShowProfileViewModel model = new ShowProfileViewModel
      {
        Profile = p
      };

      return View(model);
    }
  }
}
