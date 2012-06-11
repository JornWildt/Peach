using NUnit.Framework;
using Peach.Recipes.Query.Pages;


namespace Peach.Recipes.Query.Tests.Pages
{
  [TestFixture]
  public class PageProviderTests : TestHelper
  {
    Page MyPage;

    
    protected override void TestFixtureSetUp()
    {
      base.TestFixtureSetUp();
      MyPage = PageBuilder.Build();
    }


    [Test]
    public void CanGetPageById()
    {
      // Act
      Page r = PageProvider.Get(MyPage.Id);

      // Assert
      Assert.IsNotNull(r);
      Assert.AreEqual(MyPage.Id, r.Id);
      Assert.AreEqual(MyPage.Title, r.Title);
    }
  }
}
