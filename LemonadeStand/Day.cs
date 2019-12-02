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
        int dayCount = 7;
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

            Console.WriteLine("Looks like it is " + condition + " outside. of Day :" + dayCount + "With a high of " + temperature + ".");
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


        public void SimulateDay()
        {
            Console.WriteLine("Lemonade Recipe Game\n\n");
            // Player.PrepareRecipe();
            Console.WriteLine("\n\n Cup Per Pitcher:\n[1]Go to store \n\n[2] Play Again");
            string userInput = Console.ReadLine();
            foreach(Customer customer in customers)
            { 
            if (userInput != "1" && userInput != "2")
            {
                Console.Clear();
                //RecipeMenu();
                return;
            }
            int userInputNum = int.Parse(userInput);
                switch (userInputNum)
                {
                    case 1:
                        //Console.Clear();
                        DisplayWeather();
                       // double totalprice = Player.Store.CalculateTransactionAmount(itemcount, itemPricePerUnit);
                        break;

                    case 2:
                       // Console.Clear();
                        PlayAgainOption();
                        break;

                }
            }
        }
        private void GetCustomers(int customerCount)
        {

            for (int i = 0; i < customerCount; i++)
            {
                Customer customer = new Customer(temperature, random);
                customers.Add(customer);
            }

        }
        private void PlayAgainOption()
        {
            Console.WriteLine("Would you like to play again?");
            string userInput = Console.ReadLine();
            if (userInput == "yes" || userInput == "Yes" || userInput == "y" || userInput == "Y")
            {
                Console.Clear();
                SimulateDay();
            }
        }
    }
}

