using System.Web.Optimization;
using log4net;
using Peach.Website.Host;
using Xyperico.Base;


namespace Peach.Website.Core
{
  public class Global : Xyperico.Web.Mvc.Global
  {
    static ILog Logger = LogManager.GetLogger(typeof(Global));

    override protected void Application_Start()
    {
      base.Application_Start();
      //AreaRegistration.RegisterAllAreas();

      //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      //RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      Xyperico.Base.ObjectContainer.Container.RegisterInstance<IObjectResolver>(Xyperico.Base.ObjectContainer.Container);
    }


    protected override void RegisterRoutesBeforeAreas(System.Web.Routing.RouteCollection routes)
    {
    }
  }
}
