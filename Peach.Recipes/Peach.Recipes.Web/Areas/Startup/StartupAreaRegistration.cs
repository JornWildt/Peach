﻿using System.Web.Mvc;
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
        return "RecipesStartup";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      Logger.Debug("Register Recipes startup area");
      Initialize(Xyperico.Base.ObjectContainer.Container);
    }


    public static void Initialize(IObjectContainer container)
    {
      Peach.Recipes.Query.MongoDB.Utility.Initialize(container);
    }
  }
}
