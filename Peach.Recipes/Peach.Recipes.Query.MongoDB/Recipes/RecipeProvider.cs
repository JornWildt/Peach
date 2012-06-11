using System;
using System.Collections.Generic;
using System.Linq;
using CuttingEdge.Conditions;
using Peach.Recipes.Query.Recipes;
using MongoDB.Driver.Linq;
using MDBQuery = MongoDB.Driver.Builders.Query;


namespace Peach.Recipes.Query.MongoDB.Recipes
{
  public class RecipeProvider : PeachGenericProvider<Recipe, Guid>, IRecipeProvider
  {
    #region IRecipeProvider Members

    public Recipe GetByKey(string key)
    {
      Condition.Requires(key, "key").IsNotNull();

      return FindSingle(new { Key = key });
    }


    public IEnumerable<Recipe> Get(IList<Guid> ids)
    {
      // Create ID => Index map
      Dictionary<Guid, int> indexMap = new Dictionary<Guid, int>();
      for (int i = 0; i < ids.Count; ++i)
        indexMap[ids[i]] = i;

      var query = Collection.AsQueryable()
                            .Where(r => r.Id.In(ids))
                            .AsEnumerable()                // Perform DB lookup
                            .OrderBy(r => indexMap[r.Id]); // Sort afterwards
      return query;
    }

    #endregion
  }
}
