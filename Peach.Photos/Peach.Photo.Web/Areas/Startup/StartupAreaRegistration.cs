using System.Web.Mvc;
using log4net;
using Xyperico.Base;


namespace Peach.Photos.Web.Areas.Startup
{
  public class StartupAreaRegistration : AreaRegistration
  {
    ILog Logger = LogManager.GetLogger(typeof(StartupAreaRegistration));


    public override string AreaName
    {
      get
      {
        return "PhotosStartup";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      Logger.Debug("Register Photos startup area");
      Initialize(Xyperico.Base.ObjectContainer.Container);
    }


    public static void Initialize(IObjectContainer container)
    {
      Peach.Photos.Query.MongoDB.Utility.Initialize(container);
    }
  }
}
