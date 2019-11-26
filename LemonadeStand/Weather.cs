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
        public int TempHigh;
        Random random;
        int totalDays = 100;
        int maxTemp = 35;
        int minTemp = 98;
        public Weather(Random random)
        {
            this.random = random;
            conditions = new List<string>();
            this.TempHigh = random.Next(minTemp, maxTemp);
            CreateConditionsList();

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

        }
    }
}
