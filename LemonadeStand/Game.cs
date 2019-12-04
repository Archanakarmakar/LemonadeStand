using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public List<Day> days;
        public Player player;
        public Store store;
        Random rand = new Random();
        public int temp;
        public int daysCount = 7;
        public double totalsold = 0.0;
        public Day day;


        public Game()
        {
            day = new Day();
            days = new List<Day>() { day, day, day, day, day, day, day };
            player = new Player();
            store = new Store();

        }
        public void CreateShowDayByWeather()
        {
            for (int i = 1; i < days.Count; i++)
            {

                Console.WriteLine(days[i].weather.condition);


            }
        }



        public void Run()
        {

            for (int i = 1; i < days.Count; i++)
            {
                Console.WriteLine("You are on day " + i + " of 7");
                days[i].DisplayWeather();
                Console.WriteLine("Please hit [enter] to go to the Inventory Menu..");
                player.recipe.PrepareRecipe();

                store.SellIceCubes(player);
                store.SellLemons(player);
                store.SellSugarCubes(player);
                store.SellCups(player);

                totalsold += days[i - 1].SimulateDay(player);
                Console.WriteLine("totalsold of per day...." + totalsold);
                PlayAgainOption();

            }

        }
        private void PlayAgainOption()
        {
            Console.WriteLine("Would you like to play again?");
            string userInput = Console.ReadLine();
            if (userInput == "yes" || userInput == "Yes" || userInput == "y" || userInput == "Y")
            {
                Console.Clear();
                // totalsold =days[i-1].SimulateDay(player);
            }
        }
    }

}
