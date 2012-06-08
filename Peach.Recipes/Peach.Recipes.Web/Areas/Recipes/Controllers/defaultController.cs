using System;
using System.Web.Mvc;
using Peach.Recipes.Query.Recipes;
using Peach.Recipes.Web.Areas.Recipes.Models;


namespace Peach.Recipes.Web.Areas.Recipes.Controllers
{
  public class defaultController : Controller
  {
    #region Dependencies

    public IRecipeProvider RecipeProvider { get; set; }

    #endregion


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
