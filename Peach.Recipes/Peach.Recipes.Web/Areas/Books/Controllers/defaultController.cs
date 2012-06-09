using System.Web.Mvc;
using Peach.Recipes.Query.Books;
using Peach.Recipes.Web.Areas.Books.Models;


namespace Peach.Recipes.Web.Areas.Books.Controllers
{
  public class defaultController : Controller
  {
    #region Dependencies

    public IBookProvider BookProvider { get; set; }

    #endregion


    [HttpGet]
    public ActionResult show(string id) // id = key!
    {
      Book r = BookProvider.GetByKey(id);
      BookViewModel result = new BookViewModel
      {
        Book = r
      };
      return View(result);
    }
  }
}
