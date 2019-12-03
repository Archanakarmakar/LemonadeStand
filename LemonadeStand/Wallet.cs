using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     public class Wallet
    {
        private double money;

        public double Money
        {
            get
            {
                return money;
            }
        }

        public Wallet()
        {
            money = 20.00;
        }

        public double PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
            return money;
        }
       
        public void AddMoneytoWallet(double amount)
        {
            money += amount;
        }
    }
}

