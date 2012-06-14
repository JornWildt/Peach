using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Peach.Profiles.Query.Profiles;

namespace Peach.Profiles.TestDataGenerator.Shared
{
  public class TestDataBuilder
  {
    #region Dependencies

    public IProfileRepository ProfileRepository { get; set; }

    #endregion


    #region Created stuff

    Guid SimonProfileId = new Guid("692998CC-6732-4366-A8F9-441F8EA681B1");

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

      Profile p1 = new Profile("simon", "Simon", "The cook", SimonProfileId);
      ProfileRepository.Add(p1);

      Profile p2 = new Profile("alice", "Alice", "The chef");
      ProfileRepository.Add(p2);
    }

    #endregion
  }
}
