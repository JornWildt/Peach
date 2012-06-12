using Peach.Recipes.Query.Pages;
using Xyperico.Base.Testing;


namespace Peach.Recipes.Query.Tests.Pages
{
  public interface IPageBuilder : IDisposingBuilder<Page>
  {
    Page BuildPage(string title = "Some page", int pageNo = 1);
  }
}
