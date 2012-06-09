using System;
using System.Collections.Generic;
using Xyperico.Base;
using CuttingEdge.Conditions;


namespace Peach.Recipes.Query.Books
{
  public class Book : IHaveId<Guid>
  {
    #region Public persisted properties

    public Guid Id { get; protected set; }

    public string Key { get; protected set; }

    public string Title { get; protected set; }

    public IEnumerable<Guid> RecipeIds
    {
      get { return RecipeIdList; }
    }

    protected List<Guid> RecipeIdList { get; set; }

    #endregion


    public Book()
    {
    }


    public Book(string key, string title)
    {
      Condition.Requires(key, "key").IsNotNullOrEmpty();
      Condition.Requires(title, "title").IsNotNullOrEmpty();

      Id = Guid.NewGuid();
      RecipeIdList = new List<Guid>();

      Key = key;
      Title = title;
    }


    public void AddRecipe(Guid recipeId)
    {
      RecipeIdList.Add(recipeId);
    }
  }
}
