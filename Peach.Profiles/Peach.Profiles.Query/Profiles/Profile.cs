using System;
using Xyperico.Base;
using CuttingEdge.Conditions;


namespace Peach.Profiles.Query.Profiles
{
  public class Profile : IHaveId<Guid>
  {
    #region Public persisted properties

    public Guid Id { get; protected set; }

    public string ProfileName { get; protected set; }

    public string FullName { get; protected set; }

    public string AboutMe { get; protected set; }

    #endregion


    public Profile()
    {
    }


    public Profile(string profileName, string fullName, string aboutMe, Guid? id = null)
    {
      Condition.Requires(profileName, "profileName").IsNotNullOrEmpty();
      Condition.Requires(fullName, "fullName").IsNotNullOrEmpty();
      Condition.Requires(aboutMe, "aboutMe").IsNotNull();

      Id = id ?? Guid.NewGuid();

      ProfileName = profileName;
      FullName = fullName;
      AboutMe = aboutMe;
    }
  }
}
