using System.Collections.Generic;
using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.Web.Areas.Books.Models
{
  public class BookViewModel
  {
    public class RecipeWrapper
    {
      public Recipe Recipe { get; set; }
      public int PageNo { get; set; }
    }

    public Book Book { get; set; }
    public IList<RecipeWrapper> Recipes { get; set; }
  }
}
