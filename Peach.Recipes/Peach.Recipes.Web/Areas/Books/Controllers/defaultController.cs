using System.Linq;
using System.Web.Mvc;
using Peach.Recipes.Query.Books;
using Peach.Recipes.Web.Areas.Books.Models;
using Peach.Recipes.Query.Recipes;
using System.Collections.Generic;
using Peach.Recipes.Query.Pages;
using System;


namespace Peach.Recipes.Web.Areas.Books.Controllers
{
  public class defaultController : Controller
  {
    [HttpGet]
    public ActionResult show(string key)
    {
      Book b = BookProvider.GetByKey(key);
      
      BookViewModel result = new BookViewModel
      {
        Book = b,
        Pages = Enumerable.Empty<Page>()
      };
      return View(result);
    }


    [HttpGet]
    public ActionResult showpage(string key, int page)
    {
      Book b = BookProvider.GetByKey(key);
      Guid pageId = b.PageIds[page - 1];
      Page p = new RecipePage("TEST", 1, Guid.NewGuid());

      PageViewModel result = new PageViewModel
      {
        Book = b,
        Page = p
      };
      return View(result);
    }
  }
}
