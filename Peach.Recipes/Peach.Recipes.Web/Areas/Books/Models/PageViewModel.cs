using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.Web.Areas.Books.Models
{
  public class PageViewModel
  {
    public Book Book { get; set; }
    public Recipe Recipe { get; set; }
  }
}
