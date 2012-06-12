using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.Pages;
using Peach.Recipes.Web.Areas.Books.Models;
using Xyperico.Base;


namespace Peach.Recipes.Web.Areas.Books.Controllers
{
  public class bookController : Controller
  {
    public IObjectResolver ObjectResolver { get; set; }


    [HttpGet]
    public ActionResult show(string key)
    {
      Book b = BookProvider.GetByKey(key);
      IEnumerable<Page> pages = PageProvider.GetPages(b.PageIds);
      
      BookViewModel result = new BookViewModel
      {
        Book = b,
        Pages = pages.ToList()
      };
      return View(result);
    }


    [HttpGet]
    public ActionResult showpage(string key, int page)
    {
      Book b = BookProvider.GetByKey(key);
      Guid pageId = b.PageIds[page - 1];
      Page p = PageProvider.Get(pageId);
      p.InitializeForView(ObjectResolver);

      PageViewModel result = new PageViewModel
      {
        Book = b,
        Page = p,
        PageTemplateName = "PageTemplates/" + p.TemplateName
      };
      return View(result);
    }
  }
}
