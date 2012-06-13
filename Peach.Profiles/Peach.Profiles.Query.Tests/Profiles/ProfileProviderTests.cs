using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Peach.Profiles.Query.Profiles;

namespace Peach.Profiles.Query.Tests.Profiles
{
  [TestFixture]
  public class ProfileProviderTests : TestHelper
  {
    const string MyProfileName = "Poppins";
    Profile MyProfile;


    protected override void TestFixtureSetUp()
    {
      base.TestFixtureSetUp();
      MyProfile = ProfileBuilder.BuildProfile(MyProfileName);
    }


    [Test]
    public void CanGetProfileById()
    {
      // Act
      Profile p = ProfileProvider.Get(MyProfile.Id);

      // Assert
      Assert.IsNotNull(p);
      Assert.AreEqual(MyProfile.Id, p.Id);
      Assert.AreEqual(MyProfile.ProfileName, p.ProfileName);
      Assert.AreEqual(MyProfile.FullName, p.FullName);
      Assert.AreEqual(MyProfile.AboutMe, p.AboutMe);
    }


    [Test]
    public void CanGetProfileByProfileName()
    {
      // Act
      Profile p = ProfileProvider.GetByProfileName(MyProfile.ProfileName);

      // Assert
      Assert.IsNotNull(p);
      Assert.AreEqual(MyProfile.Id, p.Id);
      Assert.AreEqual(MyProfile.ProfileName, p.ProfileName);
    }
  }
}
