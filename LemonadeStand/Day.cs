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
            // for (int i = 1; i < dayCount; i++)
            //{
            Console.WriteLine("Looks like it is " + condition + " outside. of Day :" + dayCount + "With a high of " + temperature + ".");
            Console.ReadLine();
            //  }
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

