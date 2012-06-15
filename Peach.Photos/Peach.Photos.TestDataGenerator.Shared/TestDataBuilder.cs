using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Peach.Photos.Query.Photos;
using Peach.TestData.Shared;

namespace Peach.Photos.TestDataGenerator.Shared
{
  public class TestDataBuilder
  {
    #region Dependencies

    public IPhotoRepository PhotoRepository { get; set; }

    #endregion


    #region Created stuff
    #endregion


    public void CreateTestData()
    {
      BuildPhotos();
    }


    #region Photos

    protected void BuildPhotos()
    {
      PhotoRepository.DeleteAll();

      Console.WriteLine("Add photos");

      Photo p1 = new Photo("Burrito", "Blah", TestDataConstants.Photos.BurritoId);
      PhotoRepository.Add(p1);

      Photo p2 = new Photo("Onion tarte", "Blah", TestDataConstants.Photos.OnionTarteId);
      PhotoRepository.Add(p2);
    }

    #endregion
  }
}
