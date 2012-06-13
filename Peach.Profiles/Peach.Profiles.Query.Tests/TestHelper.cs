using Peach.Profiles.Query.Profiles;
using Peach.Profiles.Query.Tests.Profiles;


namespace Peach.Profiles.Query.Tests
{
  public class TestHelper : Xyperico.Base.Testing.TestHelper
  {
    protected IProfileProvider ProfileProvider = ObjectContainer.Resolve<IProfileProvider>();

    protected IProfileBuilder ProfileBuilder = ObjectContainer.Resolve<IProfileBuilder>();


    protected override void TestFixtureTearDown()
    {
      base.TestFixtureTearDown();
      //ProfileBuilder.DisposeInstances();
    }
  }
}
