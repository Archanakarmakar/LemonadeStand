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
        
        // 
        
        public void Run()
        {
            for (int i = 1; i < days.Count; i++)
            {
                Console.WriteLine("You are on day " + i + " of 7");
                
                //store.SellIceCubes(player);
                //store.SellLemons(player);
                //store.SellSugarCubes(player);
               days[i - 1].SimulateDay();

            }
        }
    }

}
