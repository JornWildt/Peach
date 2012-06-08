using Peach.Recipes.Query.Recipes;
using Peach.Recipes.Query.Tests.Recipes;


namespace Peach.Recipes.Query.Tests
{
  public class TestHelper : Xyperico.Base.Testing.TestHelper
  {
    protected IRecipeProvider RecipeProvider = ObjectContainer.Resolve<IRecipeProvider>();

    protected IRecipeBuilder RecipeBuilder = ObjectContainer.Resolve<IRecipeBuilder>();


    protected override void TestFixtureTearDown()
    {
      base.TestFixtureTearDown();
      RecipeBuilder.DisposeInstances();
    }
  }
}
