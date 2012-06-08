using System.Web.Optimization;
using log4net;
using Peach.Website.Host;


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
    }


    protected override void RegisterRoutesBeforeAreas(System.Web.Routing.RouteCollection routes)
    {
    }
  }
}
