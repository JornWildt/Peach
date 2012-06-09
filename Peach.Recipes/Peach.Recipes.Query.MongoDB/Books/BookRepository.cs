using System;
using Peach.Recipes.Query.Books;


namespace Peach.Recipes.Query.MongoDB.Books
{
  public class BookRepository : PeachGenericRepository<Book, Guid>, IBookRepository
  {
  }
}
