using Peach.Recipes.Query.MongoDB.Recipes;
using Peach.Recipes.Query.Recipes;
using Xyperico.Base;
using Norm.Configuration;


namespace Peach.Recipes.Query.MongoDB
{
  public static class Utility
  {
    public static void Initialize(IObjectContainer container)
    {
      Xyperico.Base.MongoDB.BsonTypeConverters.Utility.RegisterAllConverters();
      ConfigureDependencies(container);

      MongoConfiguration.Initialize(config =>
      {
        config.For<Recipe>(cfg =>
        {
          cfg.ForProperty(r => r.Ingredients).Ignore();
        });
      });
    }


    private static void ConfigureDependencies(IObjectContainer container)
    {
      container.AddComponent<IRecipeProvider, RecipeProvider>();
      container.AddComponent<IRecipeRepository, RecipeRepository>();
    }
  }
}
