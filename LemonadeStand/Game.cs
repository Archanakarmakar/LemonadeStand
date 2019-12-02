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


        public Game()
        {
            days = new List<Day>() { new Day(), new Day(), new Day(), new Day(), new Day(), new Day(), new Day() };
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
            CreateShowDayByWeather();
            Customer customer = new Customer();
            customer.CreateRandomCustomerName();
            Recipe recipe = new Recipe();
            recipe.PrepareRecipe();
            store.SellCups(player);
            store.SellIceCubes(player);
            store.SellLemons(player);
            store.SellSugarCubes(player);
            
        }
    }

}
