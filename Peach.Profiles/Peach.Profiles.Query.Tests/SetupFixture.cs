using NUnit.Framework;
using Peach.Profiles.Query.Tests.Profiles;
using Xyperico.Base;
using Xyperico.Base.Collections;


namespace Peach.Profiles.Query.Tests
{
  [SetUpFixture]
  public class SetupFixture
  {
    public static void ConfigureObjectContainer(IObjectContainer container)
    {
      container.AddComponent<INameValueContextCollection, CallContextNamedValueCollection>();

      container.AddComponent<IProfileBuilder, ProfileBuilder>();
    }


    public static void Setup(IObjectContainer container)
    {
      ConfigureObjectContainer(container);
      Peach.Profiles.Query.MongoDB.Utility.Initialize(container);
    }


    [SetUp]
    public void TestSetup()
    {
      Xyperico.Base.Testing.TestHelper.ClearObjectContainer();
      Setup(Xyperico.Base.Testing.TestHelper.ObjectContainer);
    }
  }
}
