using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        public Recipe()
        {
            this.amountOfLemons = 0;
            this.amountOfIceCubes = 0;
            this.amountOfSugarCubes = 0;
            this.pricePerCup = 0.0;

        }
        
        public void PrepareRecipe()
        {
            pricePerCup = UserInterface.GetCupPrice();
            amountOfIceCubes = UserInterface.GetRecipeForIceCube();
            amountOfLemons = UserInterface.GetRecipeForLemons();
            amountOfSugarCubes = UserInterface.GetRecipeForSugarCubes(); 
        }
    }
    
}
