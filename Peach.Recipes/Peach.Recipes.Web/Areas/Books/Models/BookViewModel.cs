using System.Collections.Generic;
using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.Web.Areas.Books.Models
{
  public class BookViewModel
  {
    public Book Book { get; set; }
    public IList<Recipe> Recipes { get; set; }
  }
}
