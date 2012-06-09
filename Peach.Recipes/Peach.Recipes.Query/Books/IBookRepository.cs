using System;


namespace Peach.Recipes.Query.Books
{
  public interface IBookRepository
  {
    void Add(Book r);
    void Delete(Guid id);
    void DeleteAll();
  }
}
