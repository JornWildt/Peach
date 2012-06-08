using System;
using System.Collections.Generic;
using Xyperico.Base;
using CuttingEdge.Conditions;


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


    public Recipe(string title, string description)
      : this()
    {
      Condition.Requires(title, "title").IsNotNullOrEmpty();
      Condition.Requires(description, "description").IsNotNull();

      Title = title;
      Description = description;
    }
  }
}
