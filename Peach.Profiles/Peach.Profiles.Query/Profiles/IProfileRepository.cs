using System;


namespace Peach.Profiles.Query.Profiles
{
  public interface IProfileRepository
  {
    void Add(Profile r);
    void Delete(Guid id);
    void DeleteAll();
  }
}
