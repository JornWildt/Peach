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
    public ActionResult show(string key)
    {
      Book b = BookProvider.GetByKey(key);
      
      IList<BookViewModel.RecipeWrapper> recipes = new List<BookViewModel.RecipeWrapper>();
      int pageNo = 1;

      foreach (Recipe r in RecipeProvider.Get(b.RecipeIds))
      {
        recipes.Add(new BookViewModel.RecipeWrapper
        {
          Recipe = r,
          PageNo = pageNo++
        });
      }

      BookViewModel result = new BookViewModel
      {
        Book = b,
        Recipes = recipes
      };
      return View(result);
    }


    [HttpGet]
    public ActionResult showpage(string key, int page)
    {
      Book b = BookProvider.GetByKey(key);
      Recipe recipe = RecipeProvider.Get(b.RecipeIds[page - 1]);

      PageViewModel result = new PageViewModel
      {
        Book = b,
        Recipe = recipe
      };
      return View(result);
    }
  }
}
