using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peach.Recipes.Query.Recipes
{
  public interface IRecipeProvider
  {
    Recipe Get(Guid id);
  }
}
