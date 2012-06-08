using System;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.Query.MongoDB.Recipes
{
  public class RecipeRepository : PeachGenericRepository<Recipe, Guid>, IRecipeRepository
  {
  }
}
