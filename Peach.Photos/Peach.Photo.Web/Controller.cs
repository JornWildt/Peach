using Peach.Photos.Query.Photos;


namespace Peach.Photos.Web
{
  public class Controller : Xyperico.Web.Mvc.Controller
  {
    #region Dependencies

    public IPhotoProvider PhotoProvider { get; set; }

    #endregion
  }
}
