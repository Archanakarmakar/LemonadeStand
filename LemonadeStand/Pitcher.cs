﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        static int cupsLeftInPitcher;
        public int numberOfPitchers;
        public Pitcher()
        {
            cupsLeftInPitcher = 0;
        }

        public void CreatePitcher(Inventory inventory, Recipe recipe)
        {
            inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
            inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
            inventory.cups.RemoveRange(0, cupsLeftInPitcher);
            cupsLeftInPitcher = 10;
        }
        public int ChooseNumberOfPitchers()
        {
            Console.WriteLine("How many pitchers do you want to make?");
                     
                int numberOfPitchers = int.Parse(Console.ReadLine());
                this.numberOfPitchers = numberOfPitchers;
                return this.numberOfPitchers;
               
        }
    }

}
