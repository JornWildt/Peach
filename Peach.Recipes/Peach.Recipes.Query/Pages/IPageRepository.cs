using System;


namespace Peach.Recipes.Query.Pages
{
  public interface IPageRepository
  {
    void Add(Page r);
    void Delete(Guid id);
    void DeleteAll();
  }
}
