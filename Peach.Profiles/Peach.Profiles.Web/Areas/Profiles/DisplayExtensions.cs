using System;
using System.Web.Mvc;
using Peach.Profiles.Query.Profiles;
using System.Web.Routing;


namespace Peach.Profiles.Web.Areas.Profiles
{
  public static class DisplayExtensions
  {
    public static MvcHtmlString DisplayProfile<T>(this HtmlHelper<T> html, Guid profileId)
    {
      IProfileProvider ProfileProvider = Xyperico.Base.ObjectContainer.Container.Resolve<IProfileProvider>();

      Profile p = ProfileProvider.Get(profileId);

      string profileUrl = UrlHelper.GenerateUrl(
        "Profiles_Default", "show", "profile", 
        new RouteValueDictionary(new { profilename = p.ProfileName }),
        html.RouteCollection, 
        html.ViewContext.HttpContext.Request.RequestContext, 
        true);

      string a = string.Format("<a href=\"{0}\">{1}</a>", profileUrl, p.FullName);
          
      return MvcHtmlString.Create(a);
    }
  }
}
