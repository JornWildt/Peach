using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xyperico.Base;
using Xyperico.Base.Collections;
using Peach.Recipes.TestDataGenerator.Shared;

namespace Peach.Recipes.TestDataGenerator
{
  class Program
  {
    static TestDataBuilder Builder;


    public static void Main(string[] args)
    {
      Configure();
      Builder.CreateTestData();
    }


    static void Configure()
    {
      Xyperico.Base.MongoDB.BsonTypeConverters.Utility.RegisterAllConverters();
      Peach.Recipes.Query.MongoDB.Utility.Initialize(Xyperico.Base.ObjectContainer.Container);
      ConfigureContainer(Xyperico.Base.ObjectContainer.Container);
      Builder = Xyperico.Base.ObjectContainer.Container.Instantiate<TestDataBuilder>();
    }


    static void ConfigureContainer(IObjectContainer container)
    {
      container.AddComponent<INameValueContextCollection, CallContextNamedValueCollection>();
    }
  }
}
