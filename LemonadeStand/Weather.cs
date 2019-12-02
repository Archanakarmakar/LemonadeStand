using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string condition;
        public List<string> conditions;
        public int temparature;
        Random random;
        int maxTemp = 101;
        int minTemp = 0;
        public Weather(Random random)
        {
            this.random = random;
            conditions = new List<string>();
            temparature = random.Next(minTemp, maxTemp);
            CreateConditionsList();
            RandomChangeCondition();
            RandomTemparature();
        }
        public int MaxTemp
        {
            get { return maxTemp; }
            private set { maxTemp = value; }
        }

        public int MinTemp
        {
            get { return minTemp; }
            private set { minTemp = value; }
        }
        public List<string> Conditions
        {
            get { return conditions; }
            private set { conditions = value; }
        }
        private void CreateConditionsList()
        {
            conditions.Add("Mostly sunny");
            conditions.Add("Partly sunny");
            conditions.Add("Partly cloudy");
            conditions.Add("Mostly cloudy");
            conditions.Add("Rainy");
            conditions.Add("Thunder storms");
            conditions.Add("Freezing ");
        }
        public string RandomChangeCondition()
        {
            int randomCondition = random.Next(0, 7);
            condition = conditions[randomCondition];
            return condition;
            //  Console.WriteLine(condition);
        }

        public void RandomTemparature()
        {
            switch (condition)
            {
                case "Freezing":
                    temparature = random.Next(0, 32);
                    break;
                case "Thunder storms":
                    temparature = random.Next(30, 43);
                    break;
                case "Partly sunny":
                    temparature = random.Next(38, 60);
                    break;
                case "Partly cloudy":
                    temparature = random.Next(38, 42);
                    break;
                case "Mostly cloudy":
                    temparature = random.Next(36, 43);
                    break;
                case "Mostly Sunny":
                    temparature = random.Next(37, 80);
                    break;
                case "Rainy":
                    temparature = random.Next(67, 72);
                    break;


            }
        }
        public int GetTemp()
        {
            int temp;
            temp = random.Next(0, 101);
            return temp;
        }
    }
}
