using System;


namespace Peach.Recipes.Query.Recipes
{
  public interface IRecipeRepository
  {
    void Add(Recipe r);
    void Delete(Guid id);
    void DeleteAll();
  }
}
