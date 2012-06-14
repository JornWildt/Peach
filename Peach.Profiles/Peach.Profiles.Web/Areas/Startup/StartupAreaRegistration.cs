using System.Web.Mvc;
using log4net;
using Xyperico.Base;


namespace Peach.Profiles.Web.Areas.Startup
{
  public class StartupAreaRegistration : AreaRegistration
  {
    ILog Logger = LogManager.GetLogger(typeof(StartupAreaRegistration));


    public override string AreaName
    {
      get
      {
        return "ProfilesStartup";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      Logger.Debug("Register Profiles startup area");
      Initialize(Xyperico.Base.ObjectContainer.Container);
    }


    public static void Initialize(IObjectContainer container)
    {
      Peach.Profiles.Query.MongoDB.Utility.Initialize(container);
    }
  }
}
