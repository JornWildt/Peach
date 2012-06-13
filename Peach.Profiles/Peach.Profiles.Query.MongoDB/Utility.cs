using MongoDB.Bson.Serialization;
using Peach.Profiles.Query.MongoDB.Profiles;
using Peach.Profiles.Query.Profiles;
using Xyperico.Base;


namespace Peach.Profiles.Query.MongoDB
{
  public static class Utility
  {
    public static void Initialize(IObjectContainer container)
    {
      Xyperico.Base.MongoDB.Utility.Initialize();

      BsonClassMap.RegisterClassMap<Profile>();

      ConfigureDependencies(container);
    }


    private static void ConfigureDependencies(IObjectContainer container)
    {
      container.AddComponent<IProfileProvider, ProfileProvider>();
      container.AddComponent<IProfileRepository, ProfileRepository>();
    }
  }
}
