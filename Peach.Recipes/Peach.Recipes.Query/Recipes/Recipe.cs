using System;
using System.Collections.Generic;
using Xyperico.Base;


namespace Peach.Recipes.Query.Recipes
{
  public class Recipe : IHaveId<Guid>
  {
    #region Public persisted properties

    public Guid Id { get; protected set; }

    public string Title { get; protected set; }

    public IEnumerable<IngredientLine> Ingredients
    {
      get { return IngredientList; }
    }

    protected List<IngredientLine> IngredientList { get; set; }

    public string Description { get; protected set; }

    #endregion


    public Recipe()
    {
      Id = Guid.NewGuid();
      IngredientList = new List<IngredientLine>();
    }
  }
}
