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

    public Page Build()
    {
      Page p = new Page("Some page", 12);
      PageRepository.Add(p);
      RegisterInstance(p);
      return p;
    }

    #endregion


    protected override void DisposeInstance(Page item)
    {
      PageRepository.Delete(item.Id);
    }
  }
}
