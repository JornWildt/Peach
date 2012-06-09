using System.Linq;
using System.Web.Mvc;
using Peach.Recipes.Query.Books;
using Peach.Recipes.Web.Areas.Books.Models;
using Peach.Recipes.Query.Recipes;
using System.Collections.Generic;


namespace Peach.Recipes.Web.Areas.Books.Controllers
{
  public class defaultController : Controller
  {


    [HttpGet]
    public ActionResult show(string id) // id = key!
    {
      Book b = BookProvider.GetByKey(id);
      IList<Recipe> recipes = RecipeProvider.Get(b.RecipeIds).ToList();

      BookViewModel result = new BookViewModel
      {
        Book = b,
        Recipes = recipes
      };
      return View(result);
    }
  }
}
