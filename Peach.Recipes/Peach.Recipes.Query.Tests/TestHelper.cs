using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.Pages;
using Peach.Recipes.Query.Recipes;
using Peach.Recipes.Query.Tests.Books;
using Peach.Recipes.Query.Tests.Pages;
using Peach.Recipes.Query.Tests.Recipes;


namespace Peach.Recipes.Query.Tests
{
  public class TestHelper : Xyperico.Base.Testing.TestHelper
  {
    protected IRecipeProvider RecipeProvider = ObjectContainer.Resolve<IRecipeProvider>();
    protected IBookProvider BookProvider = ObjectContainer.Resolve<IBookProvider>();
    protected IPageProvider PageProvider = ObjectContainer.Resolve<IPageProvider>();

    protected IRecipeBuilder RecipeBuilder = ObjectContainer.Resolve<IRecipeBuilder>();
    protected IBookBuilder BookBuilder = ObjectContainer.Resolve<IBookBuilder>();
    protected IPageBuilder PageBuilder = ObjectContainer.Resolve<IPageBuilder>();


    protected override void TestFixtureTearDown()
    {
      base.TestFixtureTearDown();
      RecipeBuilder.DisposeInstances();
      BookBuilder.DisposeInstances();
      PageBuilder.DisposeInstances();
    }
  }
}
