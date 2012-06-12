using System;
using CuttingEdge.Conditions;
using Peach.Recipes.Query.Pages;
using Xyperico.Base;


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


    public override string TemplateName
    {
      get { return "recipe"; }
    }


    public override void InitializeForView(IObjectResolver resolver)
    {
      Recipe = resolver.Resolve<IRecipeProvider>().Get(RecipeId);
    }


    public Recipe Recipe { get; protected set; }
  }
}
