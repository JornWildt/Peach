using System;


namespace Peach.Recipes.Query.Books
{
  public interface IBookProvider
  {
    Book Get(Guid id);
    Book GetByKey(string key);
  }
}
