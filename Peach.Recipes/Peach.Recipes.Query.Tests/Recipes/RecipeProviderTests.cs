using NUnit.Framework;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.Query.Tests.Recipes
{
  [TestFixture]
  public class RecipeProviderTests : TestHelper
  {
    Recipe MyRecipe;

    
    protected override void TestFixtureSetUp()
    {
      base.TestFixtureSetUp();
      MyRecipe = RecipeBuilder.Build();
    }


    [Test]
    public void CanGetRecipe()
    {
      // Act
      Recipe r = RecipeProvider.Get(MyRecipe.Id);

      // Assert
      Assert.IsNotNull(r);
      Assert.AreEqual(MyRecipe.Id, r.Id);
      Assert.AreEqual(MyRecipe.Title, r.Title);
    }
  }
}
