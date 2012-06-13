using Xyperico.Base;
using Xyperico.Base.MongoDB;


namespace Peach.Recipes.Query.MongoDB
{
  public abstract class PeachRecipesGenericProvider<T, TId> : MongoDBGenericRepository<T, TId>
    where T : class, IHaveId<TId>
  {
    public override string MongoConfigEntry
    {
      get { return "Peach.Recipes"; }
    }
  }


  public abstract class PeachRecipesGenericRepository<T, TId> : MongoDBGenericRepository<T, TId>
    where T : class, IHaveId<TId>
  {
    public override string MongoConfigEntry
    {
      get { return "Peach.Recipes"; }
    }
  }
}
