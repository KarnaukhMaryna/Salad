using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
    class Onion: Vegetable
    {
        public Onion()
        {
            Random rand = new Random();
            weight = rand.Next(80, 171);
            colour = "white";
            calories = Calories(weight);
        }

        public Onion(int weight)
        {
            this.weight = weight;
            colour = "white";
            calories = Calories(weight);
        }

        public override double Calories(int weight)
        {
            return Math.Round(weight / 100.0 * 47.0, 2);
        }

        public override string ToString()
        {
            return string.Format("Onion's weight is {0}, calories {1}, colour is {2}", arg0: weight, arg1: calories, arg2: colour);
        }
    }
}
