using Xyperico.Base;
using Xyperico.Base.MongoDB;


namespace Peach.Photos.Query.MongoDB
{
  public abstract class PeachPhotosGenericProvider<T, TId> : MongoDBGenericRepository<T, TId>
    where T : class, IHaveId<TId>
  {
    public override string MongoConfigEntry
    {
      get { return "Peach.Photos"; }
    }
  }


  public abstract class PeachPhotosGenericRepository<T, TId> : MongoDBGenericRepository<T, TId>
    where T : class, IHaveId<TId>
  {
    public override string MongoConfigEntry
    {
      get { return "Peach.Photos"; }
    }
  }
}
