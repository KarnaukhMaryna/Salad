using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
    class Сabbage: Vegetable
    {
        public Сabbage()
        {
            Random rand = new Random();
            weight = rand.Next(1500, 3500);
            colour = "white";
            calories = Calories(weight);
        }

        public Сabbage(int weight)
        {
            this.weight = weight;
            colour = "white";
            calories = Calories(weight);
        }

        public override double Calories(int weight)
        {
            return Math.Round(weight / 100.0 * 27.0, 2);
        }

        public override string ToString()
        {
            return string.Format("Cabbage's weight is {0}, calories {1}, colour is {2}", arg0: weight, arg1: calories, arg2: colour);
        }
    }
}
