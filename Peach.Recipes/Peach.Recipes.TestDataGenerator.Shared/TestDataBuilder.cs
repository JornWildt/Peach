﻿using System;
using Peach.Recipes.Query.Books;
using Peach.Recipes.Query.Recipes;


namespace Peach.Recipes.TestDataGenerator.Shared
{
  public class TestDataBuilder
  {
    #region Dependencies

    public IRecipeRepository RecipeRepository { get; set; }
    public IBookRepository BookRepository { get; set; }

    #endregion


    #region Created stuff

    Recipe MexicanskeBurritosRecipe;
    Recipe BonneMosRecipe;

    #endregion


    public void CreateTestData()
    {
      BuildRecipes();
      BuildBooks();
    }


    #region Recipes

    protected void BuildRecipes()
    {
      RecipeRepository.DeleteAll();

      Console.WriteLine("Add recipes");
      BuildMexicanskeBurritos();
      BuildBonneMos();
    }


    protected void BuildMexicanskeBurritos()
    {
      Recipe r = new Recipe("mexicanske-burritos", "Mexicanske burritos", @"Snit salat, skær tomat i både og løg og agurk i tern. Åben for dåsen med majs.

Tænd ovnen på 180º C varmluft/200º C alm. ovn.

Svits kødet i en gryde. Tilsæt krydderi og vand, og lad det simre ca. 5 min.

Fyld de mexicanske wraps med kødet. Rul dem sammen, og læg dem i et ildfast fad.
Drys osten udover. Gratineres i ovnen i ca. 10 minutter.

Serverer de varme wraps med salat, creme fraiche og salsa til.");

      r.AddIngredient(0.5f, "stk", "Hovedsalat");
      r.AddIngredient(200, "g", "Cherry tomater");
      r.AddIngredient(1, "stk", "Rødløg");
      r.AddIngredient(1, "stk", "Agurk");
      r.AddIngredient(1, "ds", "Majs på dåse");

      RecipeRepository.Add(r);
      MexicanskeBurritosRecipe = r;
    }


    protected void BuildBonneMos()
    {
      Recipe r = new Recipe("bonnemos", "Bønnemos", @"Svits løg og chili. Hæl bønnerne i og mos det hele.");

      r.AddIngredient(400, "g", "Sorte bønner");
      r.AddIngredient(2, "stk", "Løg");
      r.AddIngredient(4, "stk", "Chili");

      RecipeRepository.Add(r);
      BonneMosRecipe = r;
    }

    #endregion


    #region Books

    protected void BuildBooks()
    {
      BookRepository.DeleteAll();

      Console.WriteLine("Add books");

      Book b = new Book("mexikansk-mad", "Mexikansk mad", "En samling af mine yndlingsopskrifter fra Mexiko", Guid.NewGuid());
      b.PublishedDate = DateTime.UtcNow;

      RecipePage p1 = new RecipePage(MexicanskeBurritosRecipe.Title, 1, MexicanskeBurritosRecipe.Id);
      b.AddPage(p1.Id);

      RecipePage p2 = new RecipePage(BonneMosRecipe.Title, 2, BonneMosRecipe.Id);
      b.AddPage(p2.Id);

      BookRepository.Add(b);
    }

    #endregion
  }
}
