using System.Web.Mvc;
using Peach.Recipes.Query.Recipes;
using Peach.Recipes.Web.Areas.Recipes.Models;


namespace Peach.Recipes.Web.Areas.Recipes.Controllers
{
  public class recipeController : Controller
  {
    public static MvcHtmlString Text2Html(string text)
    {
      string s = text.Replace("\n", "<br/>");
      return MvcHtmlString.Create(s);
    }

    [HttpGet]
    public ActionResult show(string id) // id = key!
    {
      Recipe r = RecipeProvider.GetByKey(id);
      RecipeViewModel result = new RecipeViewModel
      {
        Recipe = r
      };
      return View(result);
    }
  }
}
