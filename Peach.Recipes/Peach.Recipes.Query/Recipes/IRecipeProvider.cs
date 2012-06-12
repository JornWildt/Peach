using System;
using System.Collections.Generic;


namespace Peach.Recipes.Query.Recipes
{
  public interface IRecipeProvider
  {
    Recipe Get(Guid id);
    Recipe GetByKey(string key);
  }
}
