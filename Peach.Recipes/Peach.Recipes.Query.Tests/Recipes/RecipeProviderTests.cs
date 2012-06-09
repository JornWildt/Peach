using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.Query.Tests.Recipes
{
  [TestFixture]
  public class RecipeProviderTests : TestHelper
  {
    const string MyKey = "BananaPie";
    Recipe MyRecipe;

    
    protected override void TestFixtureSetUp()
    {
      base.TestFixtureSetUp();
      MyRecipe = RecipeBuilder.Build(MyKey);
    }


    [Test]
    public void CanGetRecipeById()
    {
      // Act
      Recipe r = RecipeProvider.Get(MyRecipe.Id);

      // Assert
      Assert.IsNotNull(r);
      Assert.AreEqual(MyRecipe.Id, r.Id);
      Assert.AreEqual(MyRecipe.Title, r.Title);
    }


    [Test]
    public void CanGetRecipeByKey()
    {
      // Act
      Recipe r = RecipeProvider.GetByKey(MyRecipe.Key);

      // Assert
      Assert.IsNotNull(r);
      Assert.AreEqual(MyRecipe.Id, r.Id);
      Assert.AreEqual(MyRecipe.Key, r.Key);
      Assert.AreEqual(MyRecipe.Title, r.Title);
    }


    [Test]
    public void CanGetRecipesByListOfIds()
    {
      // Arrange
      Recipe r1 = RecipeBuilder.Build("rec1");
      Recipe r2 = RecipeBuilder.Build("rec2");
      Guid[] idList = new Guid[] { r1.Id, r2.Id };

      // Act
      IList<Recipe> recipes = RecipeProvider.Get(idList).ToList();

      // Assert
      Assert.AreEqual(2, recipes.Count);
      Assert.AreEqual(r1.Id, recipes[0].Id);
      Assert.AreEqual(r2.Id, recipes[1].Id);
    }
  }
}
