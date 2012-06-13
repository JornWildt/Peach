using Peach.Profiles.Query.Profiles;


namespace Peach.Profiles.Web
{
  public class Controller : Xyperico.Web.Mvc.Controller
  {
    #region Dependencies

    public IProfileProvider ProfileProvider { get; set; }

    #endregion
  }
}
