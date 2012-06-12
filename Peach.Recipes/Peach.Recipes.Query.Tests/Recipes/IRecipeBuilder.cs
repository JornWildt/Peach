using System;
using Peach.Recipes.Query.Recipes;
using Xyperico.Base.Testing;


namespace Peach.Recipes.Query.Tests.Recipes
{
  public interface IRecipeBuilder : IDisposingBuilder<Recipe>
  {
    Recipe BuildRecipe(string key);
    RecipePage BuildRecipePage(string recipeKey, int pageNo = 1);
  }
}
