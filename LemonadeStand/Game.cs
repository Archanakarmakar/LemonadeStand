using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        List<Day> days;
        int currentday;
        List<Player> players;
        Store store;
        Random rand = new Random();


        public Game()
        {
            days = new List<Day>() { new Day(), new Day(), new Day(), new Day(), new Day(), new Day(), new Day() };
            players = new List<Player>();
            store = new Store();
 
        }
        public void CreateShowDayByWeather()
        {
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine(days[i].weather.condition);

            }
        }
        }
        
    }
