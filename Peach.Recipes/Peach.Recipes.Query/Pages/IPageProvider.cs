using System;
using System.Collections.Generic;


namespace Peach.Recipes.Query.Pages
{
  public interface IPageProvider
  {
    Page Get(Guid id);
    IEnumerable<Page> GetPages(IList<Guid> pageIds);
  }
}
