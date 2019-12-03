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
        public List<Customer> customers = new List<Customer>();
        public int customerCount;
        Random random;
        public int temperature;
        public string condition;

        public Day()
        {
            random = new Random();
        }
        public void RunDay()
        {
            weather = new Weather(random);
            weather.RandomTemparature();
            condition = weather.RandomChangeCondition();
            customers = new List<Customer>();
            temperature = weather.GetTemp();
            ChooseNumberOfCustomers(condition);
        }
        public void DisplayWeather()
        {

            Console.WriteLine("Looks like it is " + condition + " outside. With a high of " + temperature + ".");
            Console.ReadLine();

        }


        private void ChooseNumberOfCustomers(string condition)
        {
            switch (condition)
            {
                case "Rainy":
                    customerCount = 30;
                    GetCustomers(30);
                    break;
                case "Mostly cloudy":
                    customerCount = 60;
                    GetCustomers(60);
                    break;
                case "Mostly Sunny":
                    customerCount = 120;
                    GetCustomers(120);
                    break;
                case "Partly sunny":
                    customerCount = 70;
                    GetCustomers(70);
                    break;
                case "Partly cloudy":
                    customerCount = 50;
                    GetCustomers(50);
                    break;
                case "Freezing":
                    customerCount = 20;
                    GetCustomers(20);
                    break;
                case "Thunder storms":
                    customerCount = 10;
                    GetCustomers(10);
                    break;

            }
        }


        public double SimulateDay(Player player)
        {
            double sellcount = 0;

            foreach (Customer customer in customers)
            {
                //Pitcher pitcher = new Pitcher();

                if (player.inventory.lemons.Count >= player.recipe.amountOfLemons || player.inventory.sugarCubes.Count >= player.recipe.amountOfSugarCubes || player.inventory.iceCubes.Count >= player.recipe.amountOfIceCubes || player.inventory.cups.Count >= player.recipe.pricePerCup)
                {
                    // create pitcher
                    // check if player has enough inventory to even make a pitcher or not
                    // if player does not have enough inventory, end the day

                    player.pitcher.CreatePitcher(player.inventory, player.recipe);

                    bool didChooseToBuy = customer.MakePurchaseDecision(weather, player.recipe);
                    if (didChooseToBuy)
                    {
                        
                        
                        sellcount++;
                        // give money to player
                        //take cup from pitcher
                    }
                }
                
            }
            return sellcount;
        }
        //if (temperature >= 90)
        //{
        //    Console.WriteLine("Mostly sunny!");
        //}
        //else if (temperature >= 60 && temperature < 90)
        //{
        //    Console.WriteLine("partly sunny!");
        //}
        //else if (temperature >= 30 && temperature < 60)
        //{
        //    Console.WriteLine("partly cloudy  and Rainy!");
        //}
        //else if (temperature >= 20 && temperature < 30)
        //{
        //    Console.WriteLine("ThunderStroms and Rainy!");
        //}
        //else if (temperature >= 0 && temperature < 0)
        //{
        //    Console.WriteLine("Freezing!");
        //}
        //else
        //{
        //    Console.WriteLine(".............!");
        //}


        private void GetCustomers(int customerCount)
        {

            for (int i = 0; i < customerCount; i++)
            {
                Customer customer = new Customer(temperature, random);
                customers.Add(customer);
            }

        }
    }
}


    

