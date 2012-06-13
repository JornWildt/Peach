using System;
using Peach.Profiles.Query.Profiles;


namespace Peach.Profiles.Query.MongoDB.Profiles
{
  public class ProfileRepository : PeachProfilesGenericRepository<Profile, Guid>, IProfileRepository
  {
  }
}
