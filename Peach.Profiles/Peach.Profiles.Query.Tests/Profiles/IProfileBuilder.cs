using Peach.Profiles.Query.Profiles;
using Xyperico.Base.Testing;


namespace Peach.Profiles.Query.Tests.Profiles
{
  public interface IProfileBuilder : IDisposingBuilder<Profile>
  {
    Profile BuildProfile(string key);
  }
}
