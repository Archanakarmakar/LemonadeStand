using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }


        public static double GetCupPrice()
        {
            Console.WriteLine("How much do you want to charge per cup?");
            return double.Parse(Console.ReadLine());
        }
        public static int GetRecipeForIceCube()
        {
            Console.WriteLine("How many ice cube do you want to add ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int GetRecipeForLemons()
        {
            Console.WriteLine("How many ice cube do you want to add ");
            return Convert.ToInt32(Console.ReadLine());

        }
        public static int GetRecipeForSugarCubes()
        {
            Console.WriteLine("How many ice cube do you want to add ");
            return Convert.ToInt32(Console.ReadLine());

        }


    }
}
