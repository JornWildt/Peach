using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.Pages;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.Web
{
  public class Controller : Xyperico.Web.Mvc.Controller
  {
    #region Dependencies

    public IBookProvider BookProvider { get; set; }
    public IPageProvider PageProvider { get; set; }
    public IRecipeProvider RecipeProvider { get; set; }

    #endregion
  }
}
