using CuttingEdge.Conditions;


namespace Peach.Recipes.Query.Recipes
{
  public class IngredientLine
  {
    #region Public persisted properties

    public float Quantity { get; protected set; }

    public string Unit { get; protected set; }

    public string Title { get; protected set; }

    #endregion


    public IngredientLine()
    {
    }


    public IngredientLine(float quantity, string unit, string title)
    {
      Condition.Requires(quantity, "quantity").IsGreaterThan(0);
      Condition.Requires(unit, "unit").IsNotNullOrEmpty();
      Condition.Requires(title, "title").IsNotNullOrEmpty();

      Quantity = quantity;
      Unit = unit;
      Title = title;
    }
  }
}
