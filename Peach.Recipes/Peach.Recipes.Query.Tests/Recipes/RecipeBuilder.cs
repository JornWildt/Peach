using Peach.Recipes.Query.Recipes;
using Xyperico.Base.Testing;
using Peach.Recipes.Query.Pages;
using System;
using Peach.Recipes.Query.Tests.Pages;


namespace Peach.Recipes.Query.Tests.Recipes
{
  public class RecipeBuilder : DisposingBuilder<Recipe>, IRecipeBuilder
  {
    #region Dependencies

    public IRecipeRepository RecipeRepository { get; set; }
    public IPageRepository PageRepository { get; set; }
    public IPageBuilder PageBuilder { get; set; }

    #endregion


    #region IRecipeBuilder Members

    public Recipe BuildRecipe(string key)
    {
      Recipe r = new Recipe(key, "Pancakes", "Wonderful");
      RegisterInstance(r);
      RecipeRepository.Add(r);
      return r;
    }


    public RecipePage BuildRecipePage(string recipeKey, int pageNo)
    {
      Recipe r = BuildRecipe(recipeKey);
      RecipePage p = new RecipePage(r.Title, pageNo, r.Id);
      PageBuilder.RegisterInstance(p);
      PageRepository.Add(p);
      return p;
    }

    #endregion


    protected override void DisposeInstance(Recipe item)
    {
      RecipeRepository.Delete(item.Id);
    }
  }
}
