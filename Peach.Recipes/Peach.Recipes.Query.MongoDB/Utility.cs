using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.MongoDB.Books;
using Peach.Recipes.Query.MongoDB.Pages;
using Peach.Recipes.Query.MongoDB.Recipes;
using Peach.Recipes.Query.Pages;
using Peach.Recipes.Query.Recipes;
using Xyperico.Base;
using MongoDB.Bson.Serialization;


namespace Peach.Recipes.Query.MongoDB
{
  public static class Utility
  {
    public static void Initialize(IObjectContainer container)
    {
      Xyperico.Base.MongoDB.Utility.Initialize();

      BsonClassMap.RegisterClassMap<Recipe>();
      BsonClassMap.RegisterClassMap<Book>();
      BsonClassMap.RegisterClassMap<Page>();
      BsonClassMap.RegisterClassMap<RecipePage>();
      BsonClassMap.RegisterClassMap<TextPage>();

      ConfigureDependencies(container);
    }


    private static void ConfigureDependencies(IObjectContainer container)
    {
      container.AddComponent<IRecipeProvider, RecipeProvider>();
      container.AddComponent<IRecipeRepository, RecipeRepository>();

      container.AddComponent<IPageProvider, PageProvider>();
      container.AddComponent<IPageRepository, PageRepository>();
      
      container.AddComponent<IBookProvider, BookProvider>();
      container.AddComponent<IBookRepository, BookRepository>();
    }
  }
}
