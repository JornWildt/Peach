using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using log4net;

namespace Peach.Recipes.Web.Areas.Recipes
{
  public class RecipesAreaRegistration : AreaRegistration
  {
    ILog Logger = LogManager.GetLogger(typeof(RecipesAreaRegistration));


    public override string AreaName
    {
      get
      {
        return "Recipes";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      Logger.Debug("Register recipes area");

      context.MapRoute(
        "Recipes_Default",
        "app/recipes/{controller}/{id}/{action}",
        new { action = "show" },
        new string[] { "Peach.Recipes.Web.Areas.Recipes.*" });
    }
  }
}
