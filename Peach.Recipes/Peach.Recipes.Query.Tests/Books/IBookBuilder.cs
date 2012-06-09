using Peach.Recipes.Query.Books;
using Xyperico.Base.Testing;


namespace Peach.Recipes.Query.Tests.Books
{
  public interface IBookBuilder : IDisposingBuilder<Book>
  {
    Book Build(string key);
  }
}
