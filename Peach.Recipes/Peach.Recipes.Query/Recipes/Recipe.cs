using System;
using System.Collections.Generic;
using CuttingEdge.Conditions;
using Xyperico.Base;


namespace Peach.Recipes.Query.Recipes
{
  public class Recipe : IHaveId<Guid>
  {
    #region Public persisted properties

    public Guid Id { get; protected set; }

    public string Key { get; protected set; }

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
    }


    public Recipe(string key, string title, string description)
    {
      Condition.Requires(key, "key").IsNotNullOrEmpty();
      Condition.Requires(title, "title").IsNotNullOrEmpty();
      Condition.Requires(description, "description").IsNotNull();

      Id = Guid.NewGuid();
      IngredientList = new List<IngredientLine>();

      Key = key;
      Title = title;
      Description = description;
    }


    public void AddIngredient(float quantity, string unit, string title)
    {
      IngredientLine l = new IngredientLine(quantity, unit, title);
      IngredientList.Add(l);
    }
  }
}
