using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public List<string> names;
        public string name;
        public Weather weather;
        public Random random;


        public Customer()
        {
            names = new List<string> { "John", "Susan", "Mike", "Ram", "Denise", "Lori ", "Jasmine", "Alex" };
             weather = new Weather(random);
             random = new Random();
        }
        public void CreateRandomCustomerName()
        {
            int randomName = random.Next(0, 8);
            name = names[randomName];
            Console.WriteLine("Customer name......." + name);
        }
        public void CreateCustomerDecisionMaking()
        {

        }

    }

}



