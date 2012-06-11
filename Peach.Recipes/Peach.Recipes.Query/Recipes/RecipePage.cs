using System;
using CuttingEdge.Conditions;
using Peach.Recipes.Query.Pages;


namespace Peach.Recipes.Query.Recipes
{
  public class RecipePage : Page
  {
    #region Public persisted properties

    public Guid RecipeId { get; protected set; }

    #endregion


    public RecipePage(string title, int pageNo, Guid recipeId)
      : base(title, pageNo)
    {
      Condition.Requires(recipeId, "recipeId").IsNotEqualTo(Guid.Empty);

      RecipeId = recipeId;
    }
  }
}
