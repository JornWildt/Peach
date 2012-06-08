using System;
using System.Web.Mvc;


namespace Peach.Recipes.Web.Areas.Recipes.Controllers
{
  public class recipeController : Controller
  {
    [HttpGet]
    public ActionResult show()
    {
      object recipe = new { x = 10 };
      return View(recipe);
    }
  }
}
