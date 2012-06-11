using System;
using CuttingEdge.Conditions;
using Xyperico.Base;


namespace Peach.Recipes.Query.Pages
{
  public class Page : IHaveId<Guid>
  {
    #region Public persisted properties

    public Guid Id { get; protected set; }

    public string Title { get; protected set; }

    public int PageNo { get; protected set; }

    #endregion


    public Page()
    {
    }


    public Page(string title, int pageNo)
    {
      Condition.Requires(title, "title").IsNotNullOrEmpty();
      Condition.Requires(pageNo, "pageNo").IsGreaterThan(0);

      Id = Guid.NewGuid();
      Title = title;
      PageNo = pageNo;
    }
  }
}
