using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
    class Cucumber:Vegetable
    {
        
        public Cucumber()
        {
            Random rand = new Random();
            weight = rand.Next(60, 181);
            colour = "green";
            calories = Calories(weight);
        }

        public Cucumber(int weight)
        {
            this.weight = weight;
            colour = "green";
            calories = Calories(weight);
        }

        public override double Calories(int weight)
        {
            return Math.Round(weight / 100.0 * 15.0, 2);
        }

    }
}
