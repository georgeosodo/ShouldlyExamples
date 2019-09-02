using Democode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace DemoCodeTests
{
    public class RecipeTests
    {
        [Fact]
        public void ShouldAddIngredients()
        {
            var applePie = new Recipe("Apple pie");

            applePie.AddIngredient("Apples", 200);
            applePie.AddIngredient("Sugar", 50);
            applePie.AddIngredient("Pastry", 300);

            applePie.Ingredients.ShouldContainKey("Apples");
        }
    }
}
