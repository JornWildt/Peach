﻿using Peach.Recipes.TestDataGenerator.Shared;
using Xyperico.Base;
using Xyperico.Base.Collections;


namespace Peach.Recipes.TestDataGenerator
{
  public class Program
  {
    static TestDataBuilder Builder;


    public static void Main(string[] args)
    {
      Configure();
      Builder.CreateTestData();
    }


    static void Configure()
    {
      Xyperico.Base.MongoDB.Utility.Initialize();
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
