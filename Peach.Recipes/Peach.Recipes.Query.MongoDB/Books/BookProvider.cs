using System;
using Peach.Recipes.Query.Books;
using CuttingEdge.Conditions;


namespace Peach.Recipes.Query.MongoDB.Books
{
  public class BookProvider : PeachGenericProvider<Book, Guid>, IBookProvider
  {
    #region IBookProvider Members

    public Book GetByKey(string key)
    {
      Condition.Requires(key, "key").IsNotNull();

      return FindSingle(new { Key = key });
    }

    #endregion
  }
}
