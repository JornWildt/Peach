using System;
using Peach.Recipes.Query.Recipes;
using CuttingEdge.Conditions;


namespace Peach.Recipes.Query.MongoDB.Recipes
{
  public class RecipeProvider : PeachGenericProvider<Recipe, Guid>, IRecipeProvider
  {
    #region IRecipeProvider Members

    public Recipe GetByKey(string key)
    {
      Condition.Requires(key, "key").IsNotNull();

      return FindSingle(new { Key = key });
    }

    #endregion
  }
}
