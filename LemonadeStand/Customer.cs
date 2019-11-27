using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        List<string> names;
        string name;
        Random random = new Random();
        public Customer()
        {
            names = new List<string> { "John", "Susan", "Mike", "Ram", "Denise", "Lori ", "Jasmine", "Alex" };
        }
        public void CreateRandomCustomerName()
        {
            int randomName = random.Next(0, 8);
            name = names[randomName];
            Console.WriteLine(name);

        }
    }

}

