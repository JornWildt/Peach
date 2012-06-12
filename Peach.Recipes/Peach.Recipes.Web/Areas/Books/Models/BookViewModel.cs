using System.Collections.Generic;
using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.Recipes;
using Peach.Recipes.Query.Pages;


namespace Peach.Recipes.Web.Areas.Books.Models
{
  public class BookViewModel
  {
    public Book Book { get; set; }
    public IList<Page> Pages { get; set; }
  }
}
