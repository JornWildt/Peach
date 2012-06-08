using Xyperico.Base;
using Xyperico.Base.MongoDB;


namespace Peach.Recipes.Query.MongoDB
{
  public abstract class PeachGenericProvider<T, TId> : MongoDBGenericRepository<T, TId>
    where T : class, IHaveId<TId>
  {
    public override string MongoConfigEntry
    {
      get { return "Peach.Recipes"; }
    }
  }


  public abstract class PeachGenericRepository<T, TId> : MongoDBGenericRepository<T, TId>
    where T : class, IHaveId<TId>
  {
    public override string MongoConfigEntry
    {
      get { return "Peach.Recipes"; }
    }
  }
}
