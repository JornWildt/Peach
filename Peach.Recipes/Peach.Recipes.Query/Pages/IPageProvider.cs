using System;


namespace Peach.Recipes.Query.Pages
{
  public interface IPageProvider
  {
    Page Get(Guid id);
  }
}
