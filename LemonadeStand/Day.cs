using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        List<Customer> customers;
        int dayNumber;
        Random random;
        public string day1;

        public Day()
        {
            random = new Random();
            weather = new Weather(random);
            customers = new List<Customer>();

            //CreateCustomers();

        }



    }
}

