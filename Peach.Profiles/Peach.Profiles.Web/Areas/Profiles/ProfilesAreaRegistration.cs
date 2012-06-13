using System.Web.Mvc;
using log4net;


namespace Peach.Profiles.Web.Areas.Profiles
{
  public class ProfilesAreaRegistration : AreaRegistration
  {
    ILog Logger = LogManager.GetLogger(typeof(ProfilesAreaRegistration));


    public override string AreaName
    {
      get
      {
        return "Profiles";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      Logger.Debug("Register Profiles area");

      context.MapRoute(
        "Profiles_Default",
        "profiles/{profilename}/{action}/{controller}",
        new { action = "show", controller = "profile" },
        new string[] { "Peach.Profiles.Web.Areas.Profiles.*" });
    }
  }
}
