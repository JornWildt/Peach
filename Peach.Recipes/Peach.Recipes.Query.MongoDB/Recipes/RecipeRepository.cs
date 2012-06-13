using System;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.Query.MongoDB.Recipes
{
  public class RecipeRepository : PeachRecipesGenericRepository<Recipe, Guid>, IRecipeRepository
  {
  }
}
