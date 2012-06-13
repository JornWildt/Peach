using Xyperico.Base;
using Xyperico.Base.MongoDB;


namespace Peach.Profiles.Query.MongoDB
{
  public abstract class PeachProfilesGenericProvider<T, TId> : MongoDBGenericRepository<T, TId>
    where T : class, IHaveId<TId>
  {
    public override string MongoConfigEntry
    {
      get { return "Peach.Profiles"; }
    }
  }


  public abstract class PeachProfilesGenericRepository<T, TId> : MongoDBGenericRepository<T, TId>
    where T : class, IHaveId<TId>
  {
    public override string MongoConfigEntry
    {
      get { return "Peach.Profiles"; }
    }
  }
}
