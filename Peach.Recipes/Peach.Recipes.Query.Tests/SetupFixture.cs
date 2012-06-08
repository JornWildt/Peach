using NUnit.Framework;
using Xyperico.Base;
using Peach.Recipes.Query.Tests.Recipes;
using Xyperico.Base.Collections;


namespace Peach.Recipes.Query.Tests
{
  [SetUpFixture]
  public class SetupFixture
  {
    public static void ConfigureObjectContainer(IObjectContainer container)
    {
      container.AddComponent<INameValueContextCollection, CallContextNamedValueCollection>();

      container.AddComponent<IRecipeBuilder, RecipeBuilder>();
    }


    public static void Setup(IObjectContainer container)
    {
      ConfigureObjectContainer(container);
      Peach.Recipes.Query.MongoDB.Utility.Initialize(container);
    }


    [SetUp]
    public void TestSetup()
    {
      Xyperico.Base.Testing.TestHelper.ClearObjectContainer();
      Setup(Xyperico.Base.Testing.TestHelper.ObjectContainer);
    }
  }
}
