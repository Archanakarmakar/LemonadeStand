using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string condition;
        public List<string> conditions;
        public int temparature;
        Random random;
        int maxTemp = 35;
        int minTemp = 98;
        public Weather(Random random)
        {
            this.random = random;
            conditions = new List<string>();
            temparature = random.Next(minTemp, maxTemp);
            CreateConditionsList();
            RandomChangeCondition();

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
            conditions.Add("Partly cloudy with scattered rain showers");
            conditions.Add("Mostly cloudy with scattered rain showers");
            conditions.Add("Thunder storms");
            conditions.Add("Freezing ");
        }
        public void RandomChangeCondition()
        {
          int randomCondition =  random.Next(0, 8);
            condition = conditions[randomCondition];
            Console.WriteLine(condition);
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
                case "Partly cloudy with scattered rain showers":
                    temparature = random.Next(30, 60);
                    break;
                case "Mostly cloudy with scattered rain showers":
                    temparature = random.Next(67, 72);
                    break;


            }
        }
    }
}
