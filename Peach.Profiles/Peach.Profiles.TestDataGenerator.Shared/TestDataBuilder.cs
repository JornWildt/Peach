using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Peach.Profiles.Query.Profiles;
using Peach.TestData.Shared;

namespace Peach.Profiles.TestDataGenerator.Shared
{
  public class TestDataBuilder
  {
    #region Dependencies

    public IProfileRepository ProfileRepository { get; set; }

    #endregion


    public void CreateTestData()
    {
      BuildProfiles();
    }


    #region Profiles

    protected void BuildProfiles()
    {
      ProfileRepository.DeleteAll();

      Console.WriteLine("Add Profiles");

      Profile p1 = new Profile("simon", "Simon Superion", "The cook",
                               TestDataConstants.Profiles.SimonProfileId);
      ProfileRepository.Add(p1);

      Profile p2 = new Profile("alice", "Alice Adelle Amundsen", "The chef",
                               TestDataConstants.Profiles.AliceProfileId);
      ProfileRepository.Add(p2);
    }

    #endregion
  }
}
