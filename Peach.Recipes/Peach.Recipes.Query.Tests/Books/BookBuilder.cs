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
      Book r = new Book(key, "Mexikanske specialiteter");
      BookRepository.Add(r);
      RegisterInstance(r);
      return r;
    }

    #endregion


    protected override void DisposeInstance(Book item)
    {
      BookRepository.Delete(item.Id);
    }
  }
}
