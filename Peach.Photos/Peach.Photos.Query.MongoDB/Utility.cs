using MongoDB.Bson.Serialization;
using Peach.Photos.Query.MongoDB.Photos;
using Peach.Photos.Query.Photos;
using Xyperico.Base;


namespace Peach.Photos.Query.MongoDB
{
  public static class Utility
  {
    public static void Initialize(IObjectContainer container)
    {
      Xyperico.Base.MongoDB.Utility.Initialize();

      BsonClassMap.RegisterClassMap<Photo>();

      ConfigureDependencies(container);
    }


    private static void ConfigureDependencies(IObjectContainer container)
    {
      container.AddComponent<IPhotoProvider, PhotoProvider>();
      container.AddComponent<IPhotoRepository, PhotoRepository>();
    }
  }
}
