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
        int temp;
        Random r;
       

        public Customer(int temp, Random r)

        {
            this.temp = temp;
            this.r = r;
            r = new Random();
            names = new List<string> { "John", "Susan", "Mike", "Ram", "Denise", "Lori ", "Jasmine", "Alex" };
        }

        public void CreateRandomCustomerName()
        {
            int randomName = r.Next(0, 8);
            name = names[randomName];
            Console.WriteLine("Customer name......." + name);
        }

        public bool MakePurchaseDecision(Weather weather, Recipe recipe)
        {
            if (weather.condition == "Mostly Sunny" && weather.temparature >= 90 && recipe.pricePerCup < 2.00)
            {
                return true;
            }
            else if (weather.condition == "Mostly cloudy" || weather.condition == "Partly cloudy" && weather.temparature >= 30 && recipe.pricePerCup < 1.00)
            {
                return true;
            }
            else if (weather.condition == "Rainy" || weather.condition == "Freezing" && weather.temparature < 60|| weather.temparature >= 0 && recipe.pricePerCup < 2.00)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }


}



