namespace Peach.Recipes.Query.Recipes
{
  public class IngredientLine
  {
    #region Public persisted properties

    public decimal Quantity { get; protected set; }

    public string Unit { get; protected set; }

    public string Title { get; protected set; }

    #endregion
  }
}
