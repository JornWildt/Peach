using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Peach.Recipes.Query.Pages;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.Query.Tests.Recipes
{
  [TestFixture]
  public class RecipePageProviderTests : TestHelper
  {
    [Test]
    public void CanGetRecipePage()
    {
      // Arrange
      RecipePage p1 = RecipeBuilder.BuildRecipePage("milkshake");

      // Act
      Page p2 = PageProvider.Get(p1.Id);

      // Assert
      Assert.IsInstanceOf<RecipePage>(p2);
      RecipePage rp2 = (RecipePage)p2;
      Assert.AreEqual(p1.Id, rp2.Id);
      Assert.AreEqual(p1.Title, rp2.Title);
      Assert.AreEqual(p1.PageNo, rp2.PageNo);
      Assert.AreEqual(p1.RecipeId, rp2.RecipeId);
    }


    [Test]
    public void CanGetRecipePages()
    {
      // Arrange
      RecipePage p1 = RecipeBuilder.BuildRecipePage("milkshake", 1);
      RecipePage p2 = RecipeBuilder.BuildRecipePage("hotdog", 2);
      Page p3 = PageBuilder.BuildPage("Test", 3);

      // Act
      IList<Page> pages = PageProvider.GetPages(new List<Guid> { p1.Id, p2.Id, p3.Id }).ToList();

      // Assert
      Assert.AreEqual(3, pages.Count);
      Assert.IsInstanceOf<RecipePage>(pages[0]);
      Assert.IsInstanceOf<RecipePage>(pages[1]);
      Assert.IsInstanceOf<Page>(pages[2]);
      RecipePage rp1 = (RecipePage)pages[0];
      Assert.AreEqual(p1.Id, rp1.Id);
      Assert.AreEqual(p1.Title, rp1.Title);
      Assert.AreEqual(p1.PageNo, rp1.PageNo);
      Assert.AreEqual(p1.RecipeId, rp1.RecipeId);
    }
  }
}
