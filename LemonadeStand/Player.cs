using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        public Pitcher pitcher = new Pitcher();
        public Recipe recipe = new Recipe();
        public Inventory inventory = new Inventory();
        public Wallet wallet = new Wallet();

        // constructor (SPAWNER)
        public Player()
        {
            
        }

        // member methods (CAN DO)
    }

}

