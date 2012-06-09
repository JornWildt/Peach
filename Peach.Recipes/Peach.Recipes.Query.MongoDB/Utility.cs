using MongoDB.Bson.Serialization;
using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.MongoDB.Books;
using Peach.Recipes.Query.MongoDB.Recipes;
using Peach.Recipes.Query.Recipes;
using Xyperico.Base;


namespace Peach.Recipes.Query.MongoDB
{
  public static class Utility
  {
    public static void Initialize(IObjectContainer container)
    {
      Xyperico.Base.MongoDB.Utility.Initialize();
      ConfigureDependencies(container);
    }


    private static void ConfigureDependencies(IObjectContainer container)
    {
      container.AddComponent<IRecipeProvider, RecipeProvider>();
      container.AddComponent<IRecipeRepository, RecipeRepository>();
      
      container.AddComponent<IBookProvider, BookProvider>();
      container.AddComponent<IBookRepository, BookRepository>();
    }
  }
}
