using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Peach.Recipes.Query.Recipes;

namespace Peach.Recipes.TestDataGenerator.Shared
{
  public class TestDataBuilder
  {
    #region Dependencies

    public IRecipeRepository RecipeRepository { get; set; }

    #endregion


    public void CreateTestData()
    {
      BuildRecipes();
    }


    #region Recipes

    protected void BuildRecipes()
    {
      RecipeRepository.DeleteAll();

      Console.WriteLine("Add recipes");

      Recipe r = new Recipe("mexican-casserole", "Mexican Casserole", @"In a large skillet over medium high heat, saute chicken in oil until cooked through and no longer pink inside. Add taco seasoning, beans, corn, salsa and a little water to prevent drying out. Cover skillet and simmer over medium low heat for 10 minutes.
Preheat oven to 350 degrees F (175 degrees C).
Transfer chicken mixture to a 9x13 inch baking dish. Top with 1/2 cup of the cheese and crushed tortilla chips.
Bake in the preheated oven for 15 minutes. Add remaining 1/2 cup cheese and bake until cheese is melted and bubbly.");

      RecipeRepository.Add(r);      
    }

    #endregion
  }
}
