using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xyperico.Base.Testing;
using Peach.Profiles.Query.Profiles;

namespace Peach.Profiles.Query.Tests.Profiles
{
  public class ProfileBuilder : DisposingBuilder<Profile>, IProfileBuilder
  {
    #region Dependencies

    public IProfileRepository ProfileRepository { get; set; }

    #endregion


    #region IProfileBuilder Members

    public Profile BuildProfile(string key)
    {
      Profile p = new Profile(key, "Mary Poppins", "Fun and smiling");
      RegisterInstance(p);
      ProfileRepository.Add(p);
      return p;
    }

    #endregion


    protected override void DisposeInstance(Profile item)
    {
      ProfileRepository.Delete(item.Id);
    }
  }
}
