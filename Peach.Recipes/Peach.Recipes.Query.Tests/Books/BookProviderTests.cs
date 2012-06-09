using NUnit.Framework;
using Peach.Recipes.Query.Books;


namespace Peach.Recipes.Query.Tests.Books
{
  [TestFixture]
  public class BookProviderTests : TestHelper
  {
    const string MyKey = "BananaPie";
    Book MyBook;

    
    protected override void TestFixtureSetUp()
    {
      base.TestFixtureSetUp();
      MyBook = BookBuilder.Build(MyKey);
    }


    [Test]
    public void CanGetBookById()
    {
      // Act
      Book r = BookProvider.Get(MyBook.Id);

      // Assert
      Assert.IsNotNull(r);
      Assert.AreEqual(MyBook.Id, r.Id);
      Assert.AreEqual(MyBook.Title, r.Title);
    }


    [Test]
    public void CanGetBookByKey()
    {
      // Act
      Book r = BookProvider.GetByKey(MyBook.Key);

      // Assert
      Assert.IsNotNull(r);
      Assert.AreEqual(MyBook.Id, r.Id);
      Assert.AreEqual(MyBook.Key, r.Key);
      Assert.AreEqual(MyBook.Title, r.Title);

      Assert.Fail("Must check returned order of recipes");
    }
  }
}
