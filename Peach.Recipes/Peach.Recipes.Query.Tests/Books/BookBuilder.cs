using System;
using Peach.Recipes.Query.Books;
using Xyperico.Base.Testing;


namespace Peach.Recipes.Query.Tests.Books
{
  public class BookBuilder : DisposingBuilder<Book>, IBookBuilder
  {
    #region Dependencies

    public IBookRepository BookRepository { get; set; }

    #endregion


    #region IBookBuilder Members

    public Book Build(string key)
    {
      Book b = new Book(key, "Mexikanske specialiteter", "Blah", Guid.NewGuid());
      b.PublishedDate = DateTime.Now.Date;
      BookRepository.Add(b);
      RegisterInstance(b);
      return b;
    }

    #endregion


    protected override void DisposeInstance(Book item)
    {
      BookRepository.Delete(item.Id);
    }
  }
}
