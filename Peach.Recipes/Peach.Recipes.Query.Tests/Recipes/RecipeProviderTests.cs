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
  }
}
