using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CocktailParty
{
    public class Ingredient
    {
        private string name;
        private int alcohol;
        private int quantity;

        public Ingredient(string name, int alcohol, int quantity)
        {
            this.Name = name;
            this.Alcohol = alcohol;
            this.Quantity = quantity;
        }

            public string Name { get; private set; }
            public int Alcohol { get; private set; } 
            public int Quantity { get; private set; }

        public override string ToString()
        {
            return $"Ingredient {this.Name}:" + Environment.NewLine +
                    $"Quantity: {this.Quantity}" + Environment.NewLine +
                   $"Alcohol: {this.Alcohol}";

        }


    }
}
