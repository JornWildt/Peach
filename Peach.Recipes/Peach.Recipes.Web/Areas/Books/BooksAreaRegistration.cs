using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using log4net;

namespace Peach.Recipes.Web.Areas.Books
{
  public class BooksAreaRegistration : AreaRegistration
  {
    ILog Logger = LogManager.GetLogger(typeof(BooksAreaRegistration));


    public override string AreaName
    {
      get
      {
        return "Books";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      Logger.Debug("Register Books area");

      context.MapRoute(
        "Books_Default",
        "books/{key}/{action}",
        new { action = "show", controller = "default" },
        new string[] { "Peach.Recipes.Web.Areas.Books.*" });

      context.MapRoute(
        "Books_Page",
        "books/{key}/p/{page}",
        new { action = "showpage", controller = "default" },
        new string[] { "Peach.Recipes.Web.Areas.Books.*" });
    }
  }
}
