using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.Recipes;
using Peach.Recipes.Query.Tests.Books;
using Peach.Recipes.Query.Tests.Recipes;


namespace Peach.Recipes.Query.Tests
{
  public class TestHelper : Xyperico.Base.Testing.TestHelper
  {
    protected IRecipeProvider RecipeProvider = ObjectContainer.Resolve<IRecipeProvider>();
    protected IBookProvider BookProvider = ObjectContainer.Resolve<IBookProvider>();

    protected IRecipeBuilder RecipeBuilder = ObjectContainer.Resolve<IRecipeBuilder>();
    protected IBookBuilder BookBuilder = ObjectContainer.Resolve<IBookBuilder>();


    protected override void TestFixtureTearDown()
    {
      base.TestFixtureTearDown();
      RecipeBuilder.DisposeInstances();
      BookBuilder.DisposeInstances();
    }
  }
}
