using System;
using CuttingEdge.Conditions;
using Peach.Recipes.Query.Books;


namespace Peach.Recipes.Query.MongoDB.Books
{
  public class BookProvider : PeachRecipesGenericProvider<Book, Guid>, IBookProvider
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
