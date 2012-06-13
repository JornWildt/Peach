using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver.Linq;
using Peach.Recipes.Query.Pages;


namespace Peach.Recipes.Query.MongoDB.Pages
{
  public class PageProvider : PeachRecipesGenericProvider<Page, Guid>, IPageProvider
  {
    #region IPageProvider Members

    public IEnumerable<Page> GetPages(IList<Guid> pageIds)
    {
      var query = Collection.AsQueryable()
                            .Where(p => p.Id.In(pageIds))
                            .OrderBy(p => p.PageNo);

      return query;
    }

    #endregion
  }
}
