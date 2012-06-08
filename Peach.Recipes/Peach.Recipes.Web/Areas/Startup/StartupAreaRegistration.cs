using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using log4net;
using Xyperico.Base;

namespace Peach.Recipes.Web.Areas.Startup
{
  public class StartupAreaRegistration : AreaRegistration
  {
    ILog Logger = LogManager.GetLogger(typeof(StartupAreaRegistration));


    public override string AreaName
    {
      get
      {
        return "Recipes";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      Logger.Debug("Register Startup area");
      Initialize(Xyperico.Base.ObjectContainer.Container);
    }


    public static void Initialize(IObjectContainer container)
    {
      Peach.Recipes.Query.MongoDB.Utility.Initialize(container);
    }
  }
}
