using Peach.Recipes.Query.Pages;
using Xyperico.Base.Testing;


namespace Peach.Recipes.Query.Tests.Pages
{
  public class PageBuilder : DisposingBuilder<Page>, IPageBuilder
  {
    #region Dependencies

    public IPageRepository PageRepository { get; set; }

    #endregion


    #region IPageBuilder Members

    public Page BuildPage(string title = "Some page", int pageNo = 1)
    {
      Page p = new Page(title, pageNo);
      RegisterInstance(p);
      PageRepository.Add(p);
      return p;
    }

    #endregion


    protected override void DisposeInstance(Page item)
    {
      PageRepository.Delete(item.Id);
    }
  }
}
