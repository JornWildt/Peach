using NUnit.Framework;
using Peach.Recipes.Query.Pages;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Peach.Recipes.Query.Tests.Pages
{
  [TestFixture]
  public class PageProviderTests : TestHelper
  {
    Page MyPage;

    
    protected override void TestFixtureSetUp()
    {
      base.TestFixtureSetUp();
      MyPage = PageBuilder.BuildPage();
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


    [Test]
    public void CanGetPagesByListOfIds()
    {
      // Arrange
      Page p1 = PageBuilder.BuildPage();
      Page p2 = PageBuilder.BuildPage();
      Page p3 = PageBuilder.BuildPage(); // Not used, make sure it doesn't popup in the result!
      Guid[] idList = new Guid[] { p1.Id, p2.Id };

      // Act
      IList<Page> pages = PageProvider.GetPages(idList).ToList();

      // Assert
      Assert.AreEqual(2, pages.Count);
      Assert.AreEqual(p1.Id, pages[0].Id);
      Assert.AreEqual(p2.Id, pages[1].Id);
    }
  }
}
