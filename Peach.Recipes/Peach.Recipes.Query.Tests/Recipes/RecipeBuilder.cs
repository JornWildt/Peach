using Peach.Recipes.Query.Recipes;
using Xyperico.Base.Testing;


namespace Peach.Recipes.Query.Tests.Recipes
{
  public class RecipeBuilder : DisposingBuilder<Recipe>, IRecipeBuilder
  {
    #region Dependencies

    public IRecipeRepository RecipeRepository { get; set; }

    #endregion


    #region IRecipeBuilder Members

    public Recipe Build()
    {
      Recipe r = new Recipe();
      RecipeRepository.Add(r);
      RegisterInstance(r);
      return r;
    }

    #endregion


    protected override void DisposeInstance(Recipe item)
    {
      RecipeRepository.Delete(item.Id);
    }
  }
}
