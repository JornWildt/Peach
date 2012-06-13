using System;


namespace Peach.Profiles.Query.Profiles
{
  public interface IProfileProvider
  {
    Profile Get(Guid id);
    Profile GetByProfileName(string profileName);
  }
}
