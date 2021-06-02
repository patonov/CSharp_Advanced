using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> Ingredients;
        private string name;
        private int capacity;
        private int maxAlcoholLevel;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
            this.Ingredients = new List<Ingredient>();
        }

        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public int MaxAlcoholLevel { get; private set; }

        public void Add(Ingredient ingredient)
        {
            if (ingredient.Alcohol < this.maxAlcoholLevel && ingredient.Quantity < this.Capacity)
            {
                this.Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            if (this.Ingredients.Any(x => x.Name == name))
            {
                Ingredient ing = this.Ingredients.Where(x => x.Name == name).FirstOrDefault();
                this.Ingredients.Remove(ing);
                return true; 
            }
            return false;
        }

        public Ingredient FindIngredient(string name)
        {
            if (this.Ingredients.Any(x => x.Name == name))
            {
                Ingredient ing = this.Ingredients.Where(x => x.Name == name).FirstOrDefault();
                return ing;
            }
            else
            {
                return null;
            }
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            var maxAlc = 0;

            foreach (Ingredient ing in this.Ingredients)
            {
                if (ing.Alcohol > maxAlc)
                {
                    maxAlc = ing.Alcohol;
                }
            }

            Ingredient curIng = this.Ingredients.Where(x => x.Alcohol == maxAlc).FirstOrDefault();
            return curIng;
        }

        public static int CurrentAlcoholLevel()
        {
            int alc = 0;

            foreach (Ingredient ing in this.Ingredients)
            {
                alc += ing.Alcohol;
            }
            return alc;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            int alc = 0;

            foreach (Ingredient ing in this.Ingredients)
            {
                alc += ing.Alcohol;
            }
            

            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {alc}");
            foreach (Ingredient newIng in this.Ingredients)
            {
                sb.Append($"{newIng.Name}" + Environment.NewLine);
            }
            return sb.ToString();

        }
    }
}
