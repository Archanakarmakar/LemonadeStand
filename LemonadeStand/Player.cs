using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public  class Player
    {
        string name;
        Pitcher pitcher1 = new Pitcher();
        Wallet wallet1 = new Wallet();
        Recipe recipe1 = new Recipe();
        Inventory inventory1 = new Inventory();
        public Inventory inventory;
        public Wallet wallet;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)
    }
    Player()
    {   
    }
    }
}
