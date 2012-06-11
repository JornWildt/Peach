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

    public string Introduction { get; protected set; }

    public DateTime? PublishedDate { get; set; }

    public Guid AuthorId { get; protected set; }

    public Guid[] RecipeIds
    {
      get { return RecipeIdList.ToArray(); }
    }

    protected List<Guid> RecipeIdList { get; set; }

    #endregion


    public Book()
    {
    }


    public Book(string key, string title, string introduction, Guid authorId)
    {
      Condition.Requires(key, "key").IsNotNullOrEmpty();
      Condition.Requires(title, "title").IsNotNullOrEmpty();
      Condition.Requires(introduction, "introduction").IsNotNull();

      Id = Guid.NewGuid();
      RecipeIdList = new List<Guid>();

      Key = key;
      Title = title;
      Introduction = introduction;
      AuthorId = authorId;
    }


    public void AddRecipe(Guid recipeId)
    {
      RecipeIdList.Add(recipeId);
    }
  }
}
