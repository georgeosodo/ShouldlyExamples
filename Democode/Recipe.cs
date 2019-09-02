using System;
using System.Collections.Generic;
using System.Text;

namespace Democode
{
    public class Recipe
    {
        public Recipe(string name)
        {
            Name = name;
            Ingredients = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public Dictionary<string,int> Ingredients { get; set; }

        public void AddIngredient(string IngredientName, int weight)
        {
            Ingredients.Add(IngredientName,weight);
        }
    }
}
