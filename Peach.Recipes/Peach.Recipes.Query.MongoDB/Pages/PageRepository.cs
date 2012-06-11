using System;
using Peach.Recipes.Query.Pages;


namespace Peach.Recipes.Query.MongoDB.Pages
{
  public class PageRepository : PeachGenericRepository<Page, Guid>, IPageRepository
  {
  }
}
