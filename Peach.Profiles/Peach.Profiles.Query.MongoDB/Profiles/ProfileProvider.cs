using System;
using CuttingEdge.Conditions;
using Peach.Profiles.Query.Profiles;


namespace Peach.Profiles.Query.MongoDB.Profiles
{
  public class ProfileProvider : PeachProfilesGenericProvider<Profile, Guid>, IProfileProvider
  {
    #region IProfileProvider Members

    public Profile GetByProfileName(string profileName)
    {
      Condition.Requires(profileName, "profileName").IsNotNull();

      return FindSingle(new { ProfileName = profileName });
    }

    #endregion
  }
}
