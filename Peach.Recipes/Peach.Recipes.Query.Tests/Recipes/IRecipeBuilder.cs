using Peach.Recipes.Query.Recipes;
using Xyperico.Base.Testing;


namespace Peach.Recipes.Query.Tests.Recipes
{
  public interface IRecipeBuilder : IDisposingBuilder<Recipe>
  {
    Recipe Build();
  }
}
