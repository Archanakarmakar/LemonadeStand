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
        
     
        public Game()
        {
            days = new List<Day>();
            players = new List<Player>();
            store = new Store(); 
        }
        

     }
}
